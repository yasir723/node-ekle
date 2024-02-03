# Node Ekleme

Bu C# sınıfı, ağaç veri yapısını oluşturmak için kullanılır. `tree` adlı bir sınıf içerir ve `nodeEkle` metodunu kullanarak ağaca düğüm eklemeyi sağlar.

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

<div align="center" style="border-radius: 15; overflow: hidden;">
    <img src="https://github.com/yasir723/node-ekle/assets/111686779/b8e51378-3ad1-4dac-bd43-6d5b1424b258.png" width="300">
    <img src="https://github.com/yasir723/node-ekle/assets/111686779/a5c1923f-691c-4377-bf69-636388a4ddff.png" width="300">
</div>


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

1. Eğer mevcut düğüm null ise, yeni düğüm oluşturulur ve ağacın kökü olarak atanır.
2. Eğer mevcut düğüm null değilse, eklenen değere göre ağaç içerisinde uygun konuma gidilir.
3. Eğer eklenen değer mevcut düğümün değerinden büyükse, sağ alt ağaca git ve eğer sağ alt düğüm null ise, yeni düğüm buraya eklenir; değilse, sağ alt ağacın altında işlem tekrarlanır.
4. Eğer eklenen değer mevcut düğümün değerinden küçükse, sol alt ağaca git ve eğer sol alt düğüm null ise, yeni düğüm buraya eklenir; değilse, sol alt ağacın altında işlem tekrarlanır.
5. İşlem tamamlandığında güncellenmiş ağaç yapısını temsil eden kök düğüm döndürülür.
