using System;
using System.Data;
using System.Data.SqlClient;
using ProjetoN2.Models;

namespace ProjetoN2.DAO
{
    public class SalaDAO : SuperDAO<SalaViewModel>
    {
        protected override SalaViewModel SetModel(DataRow row)
        {
            SalaViewModel salaViewModel = new SalaViewModel();
            salaViewModel.Id = Convert.ToInt32(row["sala_id"]);
            salaViewModel.Capacidade = Convert.ToInt32(row["sala_capacidade"]);

            return salaViewModel;
        }

        protected override SqlParameter[] SetParameters(SalaViewModel model)
        {
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("id", model.Id);
            parameters[1] = new SqlParameter("capacidade", model.Capacidade);

            return parameters;
        }

        protected override void SetTableName()
        {
            Table = "sala";
        }
    }
}