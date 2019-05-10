#pragma once
#include "../Face/3rd_party/seetaface2/FaceDetector2.h"
//#include "../Face/3rd_party/libfacedetect/facedetect.h"

#include "Utils.h"

#pragma comment (lib,"../Face/3rd_party/seetaface2/SeetaFaceDetector200.lib")
//#pragma comment (lib,"../Face/3rd_party/libfacedetect/libfacedetect-x64.lib")

using namespace System;
using namespace System::Collections::Generic;
using namespace System::Drawing;
using namespace System::Drawing::Imaging;
using namespace System::IO;

namespace Face
{
	public ref class Detector
	{
	public:
		Detector();
		Detector(String^ model_file_name);
		~Detector();

		List<Rectangle>^ Detect(Bitmap^ bmp);
		//List<Rectangle>^ FastDetect(Bitmap^ bmp);

	private:
		seeta::FaceDetector2* detector = nullptr;
	};
}
