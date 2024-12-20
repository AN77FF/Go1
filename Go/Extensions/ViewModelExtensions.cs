using Go.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Go.Extensions
{
    //public static class ViewModelExtensions
    //{
    //    public static T FindById<T>(this IEnumerable<T> collection, int id) where T : IModel
    //    {
    //        return collection.SingleOrDefault(item => item.Id == id);
    //    } лучше переделать
    //}
    public static class ViewModelExtensions
    {
        public static void UpdateData<T>(this ViewModelT<T> viewModel, T newData)
        {
            viewModel.Data = newData;
        }
    }
}

