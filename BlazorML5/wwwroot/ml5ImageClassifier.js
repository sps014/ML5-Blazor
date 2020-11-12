﻿let ImageClassifiers = new Object();

export function initImageClassifierVidML5(Hash, DotNet, model, video, options)
{
    let icf;
    if (options != null)
        icf = ml5.imageClassifier(model, video, options, ml5ModelLoadedImageClassifier.bind(DotNet));
    else
        icf = ml5.imageClassifier(model, video, ml5ModelLoadedImageClassifier.bind(DotNet));

    ImageClassifiers[Hash] = icf;
}
export function initImageClassifierStrML5(Hash, DotNet, model, opt)
{
    let icf;
    if (opt != null)
        icf = ml5.imageClassifier(model, opt, ml5ModelLoadedImageClassifier.bind(DotNet));
    else
        icf = ml5.imageClassifier(model, ml5ModelLoadedImageClassifier.bind(DotNet));

    ImageClassifiers[Hash] = icf;

}
export function destroyImageClassifier(hash)
{
    delete ImageClassifiers[hash];
}

export function ml5ModelLoadedImageClassifier()
{
    this.invokeMethodAsync("ICFML", "__ModelLoadedIC__");
}

export function imageClassifierClassify(hash,DotNet,image,noOfClasses)
{
    if (noOfClasses != null)
    {
        ImageClassifiers[hash].classify(image, noOfClasses, imageResultClassification.bind(DotNet));
    }
    else
    {
        ImageClassifiers[hash].classify(image, imageResultClassification.bind(DotNet));
    }


}
export function imageResultClassification(err,res)
{
    this.invokeMethodAsync("ICFCF", err, res);

}