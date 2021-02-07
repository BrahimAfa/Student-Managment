﻿using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementBeta.Etudiant
{
  public partial class ImportForm : Form
  {
    Services.EtudiantService etudaiantService = new Services.EtudiantService();
    OpenFileDialog openFileDialog1;
    TransparentPictureBox loadingPictureBox;

    public ImportForm()
    {
      InitializeComponent();
      pictureBox1.Hide();
      loadingPictureBox = new TransparentPictureBox();
      loadingPictureBox.Image = global::StudentManagementBeta.myResouces.Loader;
      openFileDialog1 = new OpenFileDialog
      {
        InitialDirectory = @"c:\",
        Title = "Browse Student CSV File",

        CheckFileExists = true,
        CheckPathExists = true,

        DefaultExt = "csv",
        Filter = "csv files (*.csv)|*.csv",
        FilterIndex = 2,
        RestoreDirectory = true,

        ReadOnlyChecked = true,
        ShowReadOnly = true
      };
    }

    private void ImportForm_Load(object sender, EventArgs e)
    {

    }
    private void txtImport_Click(object sender, EventArgs e)
    {
      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        txtImport.Enabled = false;
        txtImport.Text = openFileDialog1.FileName;
        txtDelim.Visible = true;
        AjouterEtudiant.Visible = true;
        bunifuCustomLabel1.Visible = true;
      }
    }
    private async void AjouterEtudiant_Click(object sender, EventArgs e)
    {
      pictureBox1.Show();
      pictureBox1.Update();
      var i= await Import(txtImport.Text, ",");
      MessageBox.Show(i.ToString());
      pictureBox1.Hide();
    }

    private Task<int> Import(string csvFilePath,string delimiter)
    {
      int i = 0;
      using (TextFieldParser parser = new TextFieldParser(csvFilePath))
      {
        parser.TextFieldType = FieldType.Delimited;
        parser.SetDelimiters(delimiter);
        while (!parser.EndOfData)
        {
          //Processing row
          if (i == 0) continue;
          string[] fields = parser.ReadFields();
          EtudiantModel Etud = getEtudiantFromInputs(fields);
          etudaiantService.insert(Etud);
          i++;

        }
      }
      return Task.FromResult(i);
    }
    EtudiantModel getEtudiantFromInputs(string[] fields)
    {
      string CNE = fields[0];
      string nom = fields[1];
      string prenom = fields[2];
      string sexe = fields[3];
      string date = fields[4];
      string adresse = fields[5];
      string tele = fields[6];
      int id_filiere = int.Parse(fields[7]);
      return new EtudiantModel(CNE, nom, prenom, sexe, date, adresse, tele, id_filiere);
    }

    private void bunifuImageButton1_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
