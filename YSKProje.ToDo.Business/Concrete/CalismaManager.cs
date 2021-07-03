using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.ToDo.Business.Interfaces;
using YSKProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.Business.Concrete
{
    public class CalismaManager : ICalismaService
    {
        private readonly EfCalismaRepository efCalismaRepository;
        public CalismaManager()
        {
            efCalismaRepository = new EfCalismaRepository();
        }
        public List<Calisma> GetirHepsi()
        {
            return efCalismaRepository.GetirHepsi();
        }

        public Calisma GetirIdile(int id)
        {
            return efCalismaRepository.GetirIdile(id);
        }

        public void Guncelle(Calisma tablo)
        {
            efCalismaRepository.Guncelle(tablo);
        }

        public void Kaydet(Calisma tablo)
        {
            efCalismaRepository.Kaydet(tablo);
        }

        public void Sil(Calisma tablo)
        {
            efCalismaRepository.Sil(tablo);
        }
    }
}
