using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TekSan.Migrations
{
    /// <inheritdoc />
    public partial class init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "AltText", "ContentType", "FileName", "Url" },
                values: new object[,]
                {
                    { 109, "motorlu-giyotin-cam-1", "image/jpeg", "motorlu-giyotin-cam-1.jpg", "/assets/img/properties/motorlu-giyotin-cam-1.jpg" },
                    { 110, "motorlu-giyotin-cam-2", "image/jpeg", "motorlu-giyotin-cam-2.jpg", "/assets/img/properties/motorlu-giyotin-cam-2.jpg" },
                    { 111, "motorlu-giyotin-cam-3", "image/jpeg", "motorlu-giyotin-cam-3.jpg", "/assets/img/properties/motorlu-giyotin-cam-3.jpg" },
                    { 112, "motorlu-giyotin-cam-4", "image/jpeg", "motorlu-giyotin-cam-4.jpg", "/assets/img/properties/motorlu-giyotin-cam-4.jpg" },
                    { 113, "ustte-toplanır-giyotin-cam-1", "image/jpeg", "ustte-toplanır-giyotin-cam-1.jpg", "/assets/img/properties/ustte-toplanır-giyotin-cam-1.jpg" },
                    { 114, "ustte-toplanır-giyotin-cam-2", "image/jpeg", "ustte-toplanır-giyotin-cam-2.jpg", "/assets/img/properties/ustte-toplanır-giyotin-cam-2.jpg" },
                    { 115, "ustte-toplanır-giyotin-cam-3", "image/jpeg", "ustte-toplanır-giyotin-cam-3.jpg", "/assets/img/properties/ustte-toplanır-giyotin-cam-3.jpg" },
                    { 116, "ustte-toplanır-giyotin-cam-4", "image/jpeg", "ustte-toplanır-giyotin-cam-4.jpg", "/assets/img/properties/ustte-toplanır-giyotin-cam-4.jpg" },
                    { 117, "silinebilir-giyotin-cam-1", "image/jpeg", "silinebilir-giyotin-cam-1.jpg", "/assets/img/properties/silinebilir-giyotin-cam-1.jpg" },
                    { 118, "silinebilir-giyotin-cam-2", "image/jpeg", "silinebilir-giyotin-cam-2.jpg", "/assets/img/properties/silinebilir-giyotin-cam-2.jpg" },
                    { 119, "silinebilir-giyotin-cam-3", "image/jpeg", "silinebilir-giyotin-cam-3.jpg", "/assets/img/properties/silinebilir-giyotin-cam-3.jpg" },
                    { 120, "silinebilir-giyotin-cam-4", "image/jpeg", "silinebilir-giyotin-cam-4.jpg", "/assets/img/properties/silinebilir-giyotin-cam-4.jpg" },
                    { 121, "isi-camli-giyotin-1", "image/jpeg", "isi-camli-giyotin-1.jpg", "/assets/img/properties/isi-camli-giyotin-1.jpg" },
                    { 122, "isi-camli-giyotin-2", "image/jpeg", "isi-camli-giyotin-2.jpg", "/assets/img/properties/isi-camli-giyotin-2.jpg" },
                    { 123, "isi-camli-giyotin-3", "image/jpeg", "isi-camli-giyotin-3.jpg", "/assets/img/properties/isi-camli-giyotin-3.jpg" },
                    { 124, "isi-camli-giyotin-4", "image/jpeg", "isi-camli-giyotin-4.jpg", "/assets/img/properties/isi-camli-giyotin-4.jpg" },
                    { 125, "tek-camli-giyotin-1", "image/jpeg", "tek-camli-giyotin-1.jpg", "/assets/img/properties/tek-camli-giyotin-1.jpg" },
                    { 126, "tek-camli-giyotin-2", "image/jpeg", "tek-camli-giyotin-2.jpg", "/assets/img/properties/tek-camli-giyotin-2.jpg" },
                    { 127, "tek-camli-giyotin-3", "image/jpeg", "tek-camli-giyotin-3.jpg", "/assets/img/properties/tek-camli-giyotin-3.jpg" },
                    { 128, "tek-camli-giyotin-4", "image/jpeg", "tek-camli-giyotin-4.jpg", "/assets/img/properties/tek-camli-giyotin-4.jpg" },
                    { 129, "tek-camli-giyotin-4", "image/jpeg", "tek-camli-giyotin-4.jpg", "/assets/img/properties/tek-camli-giyotin-4.jpg" },
                    { 130, "tek-camli-giyotin-4", "image/jpeg", "tek-camli-giyotin-4.jpg", "/assets/img/properties/tek-camli-giyotin-4.jpg" },
                    { 131, "tek-camli-giyotin-4", "image/jpeg", "tek-camli-giyotin-4.jpg", "/assets/img/properties/tek-camli-giyotin-4.jpg" },
                    { 132, "tek-camli-giyotin-4", "image/jpeg", "tek-camli-giyotin-4.jpg", "/assets/img/properties/tek-camli-giyotin-4.jpg" },
                    { 133, "katlanir-cam-balkon-1", "image/jpeg", "katlanir-cam-balkon-1.jpg", "/assets/img/properties/katlanir-cam-balkon-1.jpg" },
                    { 134, "katlanir-cam-balkon-2", "image/jpeg", "katlanir-cam-balkon-2.jpg", "/assets/img/properties/katlanir-cam-balkon-2.jpg" },
                    { 135, "katlanir-cam-balkon-3", "image/jpeg", "katlanir-cam-balkon-3.jpg", "/assets/img/properties/katlanir-cam-balkon-3.jpg" },
                    { 136, "katlanir-cam-balkon-4", "image/jpeg", "katlanir-cam-balkon-4.jpg", "/assets/img/properties/katlanir-cam-balkon-4.jpg" },
                    { 137, "acilir-cam-tavan-sistemleri-1", "image/jpeg", "acilir-cam-tavan-sistemleri-1.jpg", "/assets/img/properties/acilir-cam-tavan-sistemleri-1.jpg" },
                    { 138, "acilir-cam-tavan-sistemleri-2", "image/jpeg", "acilir-cam-tavan-sistemleri-2.jpg", "/assets/img/properties/acilir-cam-tavan-sistemleri-2.jpg" },
                    { 139, "acilir-cam-tavan-sistemleri-3", "image/jpeg", "acilir-cam-tavan-sistemleri-3.jpg", "/assets/img/properties/acilir-cam-tavan-sistemleri-3.jpg" },
                    { 140, "acilir-cam-tavan-sistemleri-4", "image/jpeg", "acilir-cam-tavan-sistemleri-4.jpg", "/assets/img/properties/acilir-cam-tavan-sistemleri-4.jpg" },
                    { 141, "cam-cati-sistemleri-1", "image/jpeg", "cam-cati-sistemleri-1.jpg", "/assets/img/properties/cam-cati-sistemleri-1.jpg" },
                    { 142, "cam-cati-sistemleri-2", "image/jpeg", "cam-cati-sistemleri-2.jpg", "/assets/img/properties/cam-cati-sistemleri-2.jpg" },
                    { 143, "cam-cati-sistemleri-3", "image/jpeg", "cam-cati-sistemleri-3.jpg", "/assets/img/properties/cam-cati-sistemleri-3.jpg" },
                    { 144, "cam-cati-sistemleri-4", "image/jpeg", "cam-cati-sistemleri-4.jpg", "/assets/img/properties/cam-cati-sistemleri-4.jpg" },
                    { 145, "motorlu-tente-1", "image/jpeg", "motorlu-tente-1.jpg", "/assets/img/properties/motorlu-tente-1.jpg" },
                    { 146, "motorlu-tente-2", "image/jpeg", "motorlu-tente-2.jpg", "/assets/img/properties/motorlu-tente-2.jpg" },
                    { 147, "motorlu-tente-3", "image/jpeg", "motorlu-tente-3.jpg", "/assets/img/properties/motorlu-tente-3.jpg" },
                    { 148, "motorlu-tente-4", "image/jpeg", "motorlu-tente-4.jpg", "/assets/img/properties/motorlu-tente-4.jpg" },
                    { 149, "sabit-tente-1", "image/jpeg", "sabit-tente-1.jpg", "/assets/img/properties/sabit-tente-1.jpg" },
                    { 150, "sabit-tente-2", "image/jpeg", "sabit-tente-2.jpg", "/assets/img/properties/sabit-tente-2.jpg" },
                    { 151, "sabit-tente-3", "image/jpeg", "sabit-tente-3.jpg", "/assets/img/properties/sabit-tente-3.jpg" },
                    { 152, "sabit-tente-4", "image/jpeg", "sabit-tente-4.jpg", "/assets/img/properties/sabit-tente-4.jpg" },
                    { 153, "kumandali-tente-1", "image/jpeg", "kumandali-tente-1.jpg", "/assets/img/properties/kumandali-tente-1.jpg" },
                    { 154, "kumandali-tente-2", "image/jpeg", "kumandali-tente-2.jpg", "/assets/img/properties/kumandali-tente-2.jpg" },
                    { 155, "kumandali-tente-3", "image/jpeg", "kumandali-tente-3.jpg", "/assets/img/properties/kumandali-tente-3.jpg" },
                    { 156, "kumandali-tente-4", "image/jpeg", "kumandali-tente-4.jpg", "/assets/img/properties/kumandali-tente-4.jpg" },
                    { 157, "rolling-roof-tente-1", "image/jpeg", "rolling-roof-tente-1.jpg", "/assets/img/properties/rolling-roof-tente-1.jpg" },
                    { 158, "rolling-roof-tente-2", "image/jpeg", "rolling-roof-tente-2.jpg", "/assets/img/properties/rolling-roof-tente-2.jpg" },
                    { 159, "rolling-roof-tente-3", "image/jpeg", "rolling-roof-tente-3.jpg", "/assets/img/properties/rolling-roof-tente-3.jpg" },
                    { 160, "rolling-roof-tente-4", "image/jpeg", "rolling-roof-tente-4.jpg", "/assets/img/properties/rolling-roof-tente-4.jpg" },
                    { 161, "bio-klimatik-tente-1", "image/jpeg", "bio-klimatik-tente-1.jpg", "/assets/img/properties/bio-klimatik-tente-1.jpg" },
                    { 162, "bio-klimatik-tente-2", "image/jpeg", "bio-klimatik-tente-2.jpg", "/assets/img/properties/bio-klimatik-tente-2.jpg" },
                    { 163, "bio-klimatik-tente-3", "image/jpeg", "bio-klimatik-tente-3.jpg", "/assets/img/properties/bio-klimatik-tente-3.jpg" },
                    { 164, "bio-klimatik-tente-4", "image/jpeg", "bio-klimatik-tente-4.jpg", "/assets/img/properties/bio-klimatik-tente-4.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Comment",
                value: "Giyotin cam sistemleri, özellikle teras, balkon, kış bahçesi ve geniş cephe uygulamalarında şık, kullanışlı ve modern bir çözümdür. Üstten ya da alttan raylar üzerinde dikey olarak kayan cam paneller sayesinde açıklık tamamen açılabilir ya da istenirse tamamen kapanabilir.Cam panellerin pürüzsüz kayışıyla yüksek manevra kabiliyeti sunar.Isı, ses ve rüzgâr yalıtımında etkili çözümler sağlar.Minimal profil tasarımıyla görüş alanını geniş tutar, mekâna ferahlık katar.Üstten kilit mekanizmaları ve güvenlik cam seçenekleriyle güvenli kullanım sunar.Farklı açılı uygulamalara (örneğin çatı çıkıntıları veya yüksek cepheler) adaptasyon imkânı verir.Giyotin cam sistemleri, hem estetik hem teknik açıdan yükselen bir tercih olarak dış mekânların yaşam alanına dönüşmesine katkı sağlar.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Comment",
                value: "Fotoselli giyotin cam kapı sistemleri, modern mimarinin şık görünümünü ileri düzey teknolojiyle birleştiren otomatik kapı çözümleridir. Dikey hareketli cam paneller, sensör (fotosel) yardımıyla kişi veya araç algılandığında otomatik olarak açılıp kapanır. Bu sayede hem kullanım kolaylığı hem de enerji verimliliği sağlar.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Comment",
                value: "Şeffaf kış bahçesi brandası, açık alanları dört mevsim kullanılabilir hale getiren en pratik ve ekonomik çözümlerden biridir. Soğuk, rüzgâr, yağmur ve kar gibi dış etkenlerden korunmak için tasarlanan bu sistem, mekanın doğal ışığını kesmeden mükemmel bir koruma sağlar.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Comment",
                value: "Şeffaf alan kapama sistemleri, açık alanları dış etkenlerden koruyarak dört mevsim kullanılabilir hale getiren modern çözümlerdir. Yüksek kaliteli şeffaf PVC malzemeden üretilen bu brandalar, hem dayanıklı hem de estetik bir kullanım sunar. Mekânın doğal ışığını engellemeden koruma sağlar; böylece iç mekânlar ferahlığını kaybetmeden dış ortam koşullarına karşı korunur.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Comment",
                value: "Şeffaf PVC Mika branda, dış mekânları her mevsim konforlu ve kullanışlı hale getiren modern koruma sistemlerinden biridir. Tam şeffaf yapısı sayesinde dış ortamla görsel bağlantıyı kesmeden, yağmur, rüzgâr, toz ve soğuk gibi olumsuz hava koşullarına karşı mükemmel koruma sağlar.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Comment",
                value: "Havuz brandası, yüzme havuzlarını dış etkenlerden korumak, güvenliği artırmak ve temizlik maliyetlerini düşürmek için geliştirilen dayanıklı bir kaplama sistemidir. Mevsimsel kullanıma uygun olan bu brandalar, hem açık hem de kapalı havuzlarda estetik ve fonksiyonel bir çözüm sunar.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "Comment",
                value: "İskele brandası, inşaat ve tadilat alanlarında güvenliği sağlamak, çevreyi korumak ve estetik bir görünüm oluşturmak amacıyla kullanılan özel bir koruma sistemidir. Dayanıklı PVC veya polietilen (PE) malzemeden üretilen iskele brandaları, hem çalışanların hem de çevredeki insanların güvenliğini artırırken, yapı alanını dış etkenlerden korur.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "Comment",
                value: "Kamelya brandası, açık alanlarda bulunan kamelya, çardak ve oturma alanlarını dört mevsim koruma altına almak için tasarlanmış şık ve dayanıklı bir kaplama sistemidir. Estetik görünümü, uzun ömürlü malzemesi ve hava koşullarına karşı yüksek direnci sayesinde konforlu bir dış mekân deneyimi sunar.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "Comment",
                value: "Pazar brandası, açık alanlarda kurulan pazar yerleri, tezgâhlar ve satış alanlarını güneş, yağmur, rüzgâr gibi dış etkenlerden korumak için özel olarak üretilen dayanıklı kaplama sistemidir. Hafif yapısı, kolay kurulumu ve uzun ömürlü malzemesi sayesinde esnaflar ve organizasyon alanları için pratik bir çözümdür.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "Comment",
                value: "Reklam brandası, markanı veya işletmeni geniş kitlelere tanıtmak için kullanılan en etkili ve ekonomik açık hava reklam çözümlerinden biridir. Dayanıklı branda kumaşı üzerine yüksek çözünürlüklü dijital baskı uygulanarak üretilen bu sistemler, hem iç hem de dış mekânlarda uzun süreli görünürlük sağlar.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "Comment",
                value: "Araç koruma brandası, otomobilleri güneş, yağmur, dolu, kar, kuş pisliği, toz ve ağaç reçinesi gibi dış etkenlerden korumak için özel olarak tasarlanmış pratik bir örtü sistemidir. Dayanıklı, su geçirmez ve UV ışınlarına karşı dirençli yapısı sayesinde aracınızın dış yüzeyini her mevsim güvenle korur.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "Comment",
                value: "Yat ve tekne brandası, deniz taşıtlarını güneş, tuzlu su, yağmur, rüzgâr ve kuş pisliği gibi dış etkenlerden korumak için özel olarak tasarlanmış dayanıklı bir koruma sistemidir. Su geçirmez, UV dayanımlı ve uzun ömürlü kumaş yapısı sayesinde teknenizi yıl boyunca güvenle muhafaza eder.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "Comment",
                value: "Cam balkon sistemleri, balkonları dört mevsim kullanılabilir hale getiren, modern, estetik ve fonksiyonel bir kaplama çözümüdür. Isı, ses ve rüzgâr yalıtımı sağlayan bu sistemler, mekânın mimarisine değer katarken yaşam alanlarına da konfor kazandırır.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "Comment",
                value: "Cam veranda sistemleri, açık alanları modern, estetik ve korunaklı yaşam alanlarına dönüştüren şık mimari çözümlerden biridir. Dört mevsim kullanılabilen yapısıyla verandanı hem yağmurdan hem rüzgârdan korur; aynı zamanda ferah, aydınlık ve konforlu bir ortam oluşturur.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "Comment",
                value: "Depo çadırı, sanayi, tarım ve lojistik sektörlerinde malzeme, ürün ve ekipmanların güvenli bir şekilde korunması için tasarlanmış, dayanıklı ve ekonomik bir kapalı alan çözümüdür. Hızlı kurulumu, taşınabilir yapısı ve uzun ömürlü malzemesi sayesinde kalıcı binalara alternatif olarak sıkça tercih edilir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "Comment",
                value: "Doğal afet çadırı, deprem, sel, yangın, fırtına veya diğer acil durumlarda barınma ihtiyacını hızlı bir şekilde karşılamak üzere tasarlanmış, dayanıklı ve pratik kurulumlu geçici yaşam alanıdır. Zorlu hava koşullarına dayanıklı yapısı ve kolay taşınabilirliği sayesinde, afet bölgelerinde en güvenilir barınma çözümlerinden biridir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "Comment",
                value: "Halı saha çadırı, açık veya kapalı spor alanlarını dört mevsim kullanılabilir hale getiren, dayanıklı ve estetik bir kaplama sistemidir. Spor tesisleri için özel olarak tasarlanan bu yapılar; hava koşullarına karşı tam koruma sağlarken, aynı zamanda modern ve ferah bir oyun ortamı sunar.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "Comment",
                value: "Hayvan besi çadırı, büyükbaş ve küçükbaş hayvanların barınma, beslenme ve üretim süreçlerinde kullanılan, dayanıklı ve ekonomik bir barınak çözümüdür. Hızlı kurulumu, geniş iç hacmi ve uzun ömürlü yapısıyla modern hayvancılık işletmeleri için ideal bir seçenektir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "Comment",
                value: "Spor kompleksi çadırı, kapalı veya yarı kapalı spor alanlarını dört mevsim kullanılabilir hale getiren modern, dayanıklı ve ekonomik çözümlerden biridir. Hızlı kurulumu, uzun ömürlü yapısı ve estetik tasarımı sayesinde farklı spor dallarına uygun, geniş ve ferah bir oyun alanı oluşturur.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "Comment",
                value: "Şantiye çadırı, inşaat ve saha çalışmalarında personel, malzeme ve ekipmanların korunması için kullanılan pratik, dayanıklı ve ekonomik barınma çözümlerinden biridir. Hızlı kurulumu, taşınabilir yapısı ve uzun ömürlü malzemesi sayesinde her türlü zemin ve iklim koşulunda güvenli kullanım sağlar.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "Comment",
                value: "Kiralık çadır sistemleri, kısa süreli organizasyon, etkinlik, fuar, düğün, inşaat veya geçici depolama ihtiyaçları için en pratik ve ekonomik çözümlerden biridir. Dayanıklı yapısı, kolay kurulumu ve taşınabilirliği sayesinde farklı sektörlerde güvenle kullanılabilir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "Comment",
                value: "Konser ve tören çadırı sistemleri, açık alan etkinliklerinde hava koşullarından etkilenmeden güvenli, konforlu ve estetik bir organizasyon ortamı oluşturmak için tasarlanmış modern çözümlerdir. Dayanıklı yapısı, geniş alan kaplama kapasitesi ve şık tasarımıyla her türlü etkinliğe profesyonel bir görünüm kazandırır.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "Comment",
                value: "Sürgülü sineklik sistemleri, pencere ve kapılarda havalandırma konforunu bozmadan sinek, böcek ve haşerelere karşı etkili koruma sağlayan pratik çözümlerdir. Şık tasarımı, kolay kullanımı ve uzun ömürlü yapısıyla modern yaşam alanlarının vazgeçilmez bir parçasıdır.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "Comment",
                value: "Motorlu giyotin cam sistemleri, modern mimarinin en şık ve işlevsel çözümlerinden biridir. Dikey hareketle çalışan otomatik cam paneller, uzaktan kumanda veya buton yardımıyla kolayca açılıp kapanabilir. Bu sayede mekanlarda estetik, konfor ve teknolojiyi bir arada sunar.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "Comment",
                value: "Üstte toplanır giyotin cam sistemleri, modern mimaride estetik ve konforu bir araya getiren yenilikçi bir cam kapama çözümüdür. Dikey hareketli paneller, özel motor sistemi sayesinde yukarı doğru toplanarak açık alanların pratik şekilde kontrol edilmesini sağlar. Kafe, restoran, otel, veranda ve teraslarda sıklıkla tercih edilir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "Comment",
                value: "Silinebilir giyotin cam sistemleri, modern yapılarda estetik görünüm, konfor ve kolay bakım avantajlarını bir arada sunan yenilikçi bir cam kaplama çözümüdür. Dikey hareketli cam paneller, özel mekanizması sayesinde kolayca temizlenebilir ve bakım gerektirmeden uzun yıllar kullanılabilir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "Comment",
                value: "Isı camlı giyotin cam sistemleri, modern mimarinin zarif tasarımını yüksek ısı yalıtımıyla birleştiren yenilikçi bir cam kapama çözümüdür. Dikey hareketli cam paneller, uzaktan kumanda veya buton yardımıyla kolayca kontrol edilirken, çift cam teknolojisi sayesinde hem enerji tasarrufu hem de konfor sağlar.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "Comment",
                value: "Tek camlı giyotin sistemleri, modern mimarinin zarif çizgilerini pratik kullanım ve ekonomik çözümlerle birleştiren yenilikçi cam kapama sistemleridir. Dikey hareketle çalışan cam paneller, motorlu veya manuel mekanizma sayesinde kolayca açılıp kapanabilir. Şeffaf, estetik ve hafif yapısıyla hem konut hem de ticari alanlarda sıkça tercih edilir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "Comment",
                value: "Kumandalı giyotin cam sistemleri, modern yaşam alanlarında konfor, güvenlik ve estetiği bir araya getiren yenilikçi bir cam kaplama çözümüdür. Uzaktan kumanda veya buton yardımıyla kolayca kontrol edilen dikey hareketli cam paneller, açık alanları dilediğin gibi yönetme özgürlüğü sunar.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "Comment",
                value: "Katlanır cam balkon sistemleri, modern yaşam alanlarında estetik, konfor ve fonksiyonelliği bir araya getiren en popüler cam kapama çözümlerinden biridir. Cam panellerin yana doğru katlanarak tamamen açılabilmesi, balkonları ve terasları dört mevsim kullanılabilir hale getirir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "Comment",
                value: "Açılır cam tavan sistemleri, iç mekânlara doğal ışık kazandırırken dış etkenlerden korunmayı sağlayan modern ve estetik mimari çözümlerden biridir. Uzaktan kumanda veya manuel mekanizma ile kolayca açılıp kapanabilen bu sistemler, yaşam alanlarını dört mevsim kullanılabilir hale getirir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "Comment",
                value: "Cam çatı sistemleri, mimaride şeffaflık ve doğal ışığı ön plana çıkaran modern bir kaplama çözümüdür. Dayanıklı yapısı ve estetik görünümüyle hem konutlarda hem de ticari yapılarda tercih edilir. Geniş açıklıkları kapatarak mekânlara ferahlık kazandıran bu sistemler, dört mevsim konforu bir arada sunar.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "Comment",
                value: "Motorlu tente sistemleri, modern yaşam alanlarında konfor, estetik ve işlevselliği bir araya getiren en pratik gölgelendirme çözümlerinden biridir. Uzaktan kumanda, buton veya sensör desteğiyle kolayca açılıp kapanan bu sistemler, güneşten, yağmurdan ve rüzgârdan koruma sağlayarak açık alanları dört mevsim kullanılabilir hale getirir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "Comment",
                value: "Sabit tente sistemleri, dayanıklılığı ve estetik görünümüyle uzun yıllar boyunca koruma sağlayan en klasik ve güvenilir gölgelendirme çözümlerinden biridir. Yapıya sabit şekilde monte edilen bu tenteler, her türlü hava koşuluna karşı koruma sunarken mekânlara modern bir görünüm kazandırır.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "Comment",
                value: "Kumandalı tente sistemleri, modern yaşam alanlarında konforu ve estetiği bir araya getiren en gelişmiş gölgelendirme çözümlerinden biridir. Uzaktan kumanda veya buton yardımıyla kolayca açılıp kapanabilen bu sistemler, hem kullanıcı dostu yapısı hem de şık tasarımıyla açık alanları dört mevsim kullanılabilir hale getirir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Comment", "Slug" },
                values: new object[] { "Rolling Roof tente sistemleri, modern mimarinin en yenilikçi dış mekân çözümlerinden biridir. Açılır-kapanır tavan yapısı sayesinde tam gölgelendirme, havalandırma ve koruma sunan bu sistem, hem estetik hem de teknolojik yapısıyla yaşam alanlarını dört mevsim kullanılabilir hale getirir.", "rolling-roof-tente" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "Comment",
                value: "Biyoklimatik tente sistemleri, doğa ile uyumlu şekilde tasarlanmış, modern yaşam alanlarına konfor ve estetik kazandıran ileri teknoloji gölgelendirme çözümleridir. Alüminyum panellerin açılıp kapanabilen yapısı sayesinde güneş ışığını, havayı ve yağmuru kontrollü şekilde yönlendirir; böylece açık alanlar dört mevsim kullanılabilir hale gelir.");

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "DisplayOrder", "IsMain", "MediaId", "ProductId" },
                values: new object[,]
                {
                    { 108, 3, true, 109, 29 },
                    { 109, 3, false, 110, 29 },
                    { 110, 3, false, 111, 29 },
                    { 111, 3, false, 112, 29 },
                    { 112, 3, true, 113, 30 },
                    { 113, 3, false, 114, 30 },
                    { 114, 3, false, 115, 30 },
                    { 115, 3, false, 116, 30 },
                    { 116, 3, true, 117, 31 },
                    { 117, 3, false, 118, 31 },
                    { 118, 3, false, 119, 31 },
                    { 119, 3, false, 120, 31 },
                    { 120, 3, true, 121, 32 },
                    { 121, 3, false, 122, 32 },
                    { 122, 3, false, 123, 32 },
                    { 123, 3, false, 124, 32 },
                    { 124, 3, true, 125, 33 },
                    { 125, 3, false, 126, 33 },
                    { 126, 3, false, 127, 33 },
                    { 127, 3, false, 128, 33 },
                    { 128, 3, true, 129, 34 },
                    { 129, 3, false, 130, 34 },
                    { 130, 3, false, 131, 34 },
                    { 131, 3, false, 132, 34 },
                    { 132, 3, true, 133, 35 },
                    { 133, 3, false, 134, 35 },
                    { 134, 3, false, 135, 35 },
                    { 135, 3, false, 136, 35 },
                    { 136, 3, true, 137, 36 },
                    { 137, 3, false, 138, 36 },
                    { 138, 3, false, 139, 36 },
                    { 139, 3, false, 140, 36 },
                    { 140, 3, true, 141, 37 },
                    { 141, 3, false, 142, 37 },
                    { 142, 3, false, 143, 37 },
                    { 143, 3, false, 144, 37 },
                    { 144, 3, true, 145, 38 },
                    { 145, 3, false, 146, 38 },
                    { 146, 3, false, 147, 38 },
                    { 147, 3, false, 148, 38 },
                    { 148, 3, true, 149, 39 },
                    { 149, 3, false, 150, 39 },
                    { 150, 3, false, 151, 39 },
                    { 151, 3, false, 152, 39 },
                    { 152, 3, true, 153, 40 },
                    { 153, 3, false, 154, 40 },
                    { 154, 3, false, 155, 40 },
                    { 155, 3, false, 156, 40 },
                    { 156, 3, true, 157, 41 },
                    { 157, 3, false, 158, 41 },
                    { 158, 3, false, 159, 41 },
                    { 159, 3, false, 160, 41 },
                    { 160, 3, true, 161, 42 },
                    { 161, 3, false, 162, 42 },
                    { 162, 3, false, 163, 42 },
                    { 163, 3, false, 163, 42 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Comment", "Slug" },
                values: new object[] { "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.", "rolling-roof-tente " });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "Comment",
                value: "Mafsallı tente gerek kış aylarında oluşabilecek olumsuz hava koşullarından korunmak gerekse yazın güneşten kaçınmak için yaptırılan kurulumu ve kullanıma kolay bir tente modelidir.");
        }
    }
}
