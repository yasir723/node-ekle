# Node Ekleme

Bu C# sınıfı, binary ağaç veri yapısını oluşturmak için kullanılır. `tree` adlı bir sınıf içerir ve `nodeEkle` metodunu kullanarak ağaca düğüm eklemeyi sağlar.

## `tree` Sınıfı

```csharp
class tree
{
    public int value;
    public tree right;
    public tree left;
}
```

### Özellikler

- `value`: Düğümün değerini temsil eder.
- `right`: Düğüme bağlı olan sağ alt düğümü belirtir.
- `left`: Düğüme bağlı olan sol alt düğümü belirtir.

## `nodeEkle` Metodu
```csharp
static tree nodeEkle(tree node, int value)
{
    tree tmp = new tree();
    tmp.value = value;

    if (node == null)
    {
        node = tmp;
        return node;
    }

    if (node.value < value)
    {
        if (node.right == null)
            node.right = tmp;
        else
            nodeEkle(node.right, value);
    }

    if (node.value > value)
    {
        if (node.left == null)
            node.left = tmp;
        else
            nodeEkle(node.left, value);
    }

    return node;
}
```

## Parametreler

- `node`: Ağaçtaki mevcut düğüm.
- `value`: Eklenecek düğümün değeri.

## Dönüş Değeri

Metot, güncellenmiş ağaç yapısını temsil eden kök düğümü döndürür.

## İşleyiş

1. Eğer mevcut düğüm null ise, yeni düğüm oluşturulur ve binary ağacın kökü olarak atanır.
2. Eğer mevcut düğüm null değilse, eklenen değere göre ağaç içerisinde uygun konuma gidilir.
3. Eğer eklenen değer mevcut düğümün değerinden büyükse, sağ alt ağaca git ve eğer sağ alt düğüm null ise, yeni düğüm buraya eklenir; değilse, sağ alt ağacın altında işlem tekrarlanır.
4. Eğer eklenen değer mevcut düğümün değerinden küçükse, sol alt ağaca git ve eğer sol alt düğüm null ise, yeni düğüm buraya eklenir; değilse, sol alt ağacın altında işlem tekrarlanır.
5. İşlem tamamlandığında güncellenmiş ağaç yapısını temsil eden kök düğüm döndürülür.

# Örnek 

Aşağıdaki gibi bir binary ağaç düşünelim:

<div align="center">
    <h3>Ağaç</h3>
    <img src="https://github.com/yasir723/node-ekle/assets/111686779/c33ab601-25a4-481c-9ba0-82a6da5de37a" width="600">
</div>

Bu binary ağaca yeni bir düğüm eklemek istiyoruz. Ekleyeceğimiz düğümün değeri 11 olsun.

<div align="center">
    <h3>Sonuç</h3>
    <img src="https://github.com/yasir723/node-ekle/assets/111686779/82157c2a-7957-47b4-9f59-6ef645360785" width="600">
</div>


