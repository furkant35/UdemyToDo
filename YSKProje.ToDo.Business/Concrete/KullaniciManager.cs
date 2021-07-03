using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.ToDo.Business.Interfaces;
using YSKProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.Business.Concrete
{
    public class KullaniciManager : IKullaniciService
    {
        private readonly EfKullaniciRepository efKullaniciRepository;
        public KullaniciManager()
        {
            efKullaniciRepository = new EfKullaniciRepository();
        }
        public List<Kullanici> GetirHepsi()
        {
            return efKullaniciRepository.GetirHepsi();
        }

        public Kullanici GetirIdile(int id)
        {
            return efKullaniciRepository.GetirIdile(id);
        }

        public void Guncelle(Kullanici tablo)
        {
            efKullaniciRepository.Guncelle(tablo);
        }

        public void Kaydet(Kullanici tablo)
        {
            efKullaniciRepository.Kaydet(tablo);
        }

        public void Sil(Kullanici tablo)
        {
            efKullaniciRepository.Sil(tablo);
        }
    }
}
