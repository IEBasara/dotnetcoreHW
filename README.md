<h1 align="center">SmartHome Gesture Control Application: Part 2</h1>
<p>
  <a href="mailto:cchou40@asu.edu" target="_blank">
    <img alt="Email: cchou40@asu.edu" src="https://img.shields.io/badge/Email-cchou40%40asu.edu-yellow" />
  </a>
  <img alt="Version" src="https://img.shields.io/badge/version-1.0.0.0-blue.svg?cacheSeconds=2592000" />
  <a href="https://iebasara.net" target="_blank">
    <img alt="Documentation" src="https://img.shields.io/badge/documentation-yes-brightgreen.svg" />
  </a>
  <a href="#" target="_blank">
    <img alt="License: Eric Chou" src="https://img.shields.io/badge/License-Eric Chou-yellow.svg" />
  </a>
  <a href="https://twitter.com/iebasara" target="_blank">
    <img alt="Twitter: iebasara" src="https://img.shields.io/twitter/follow/iebasara.svg?style=social" />
  </a>
</p>

> ASU 2022 Spring A. CSE535 Mobile Computing. SmartHome Gesture Control Application: Part 2 

## My approach to the given problem
I extract the middle frames of each video and see the similarity or differences between them. I found that the dimensions of the images between the training and test images are different, and the skin color is also not similar to the training images at all. And the size scale of the gestures of the image is also different. 

I saw the feature extraction code and found that all the photos need to convert to grayscale and resized to a specific square size before the feature extraction.
The first thing that comes up to me is that I have to make them be at a similar scale of ROIs (Region Of Interests), and they should be in squares so that we can extract their features based on an approximate condition. 

I use the skin color filter (through HSV and YCrCb color space) to keep the gesture part of the image. Then for the filtered image, I convert them to grayscale and use a binary threshold filter to filter them to binary images. I get the overall gesture bounding box of the images using Canny edge detection, finding contours, and connecting all the shapes. 

Then, I use a piece of code to reason the correction offset of the bounding box of the gestures so that each bounding box of them has a reasonable margin to the edge of the ROIs and make them in squares.

Finally, I fed the cropped ROIs to the feature extractor to predict the feature vectors. And then calculate the cosine similarity between each feature of ROIs to find the closest match.

## The solution for the problem 
1)	Preprocess: 
    Noise reduction: Gaussian blur with kernel 3x3.
2)	ROI Extraction:

	i.	Skin color filter (HSV, YCrCb)
  
	ii.	Binarize the image
  
	iii.	Canny edge detection
  
	iv.	Find contours and determine bounding box (a square ROI region)
  
	v.	Crop ROI
3)	Feature extraction
4)	Cosine similarity comparison between each ROIs for the closest match

***
## Author

👤 **Eric Chou**

* Website: https://iebasara.net
* Twitter: [@iebasara](https://twitter.com/iebasara)
* Github: [@iebasara](https://github.com/iebasara)
* LinkedIn: [@iebasara](https://linkedin.com/in/iebasara)
