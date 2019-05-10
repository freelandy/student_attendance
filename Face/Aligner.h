#pragma once
#include "../Face/3rd_party/seetaface2/PointDetector2.h"

#include "Utils.h"

#pragma comment (lib,"../Face/3rd_party/seetaface2/SeetaPointDetector200.lib")

using namespace System;
using namespace System::Collections::Generic;
using namespace System::Drawing;
using namespace System::Drawing::Imaging;
using namespace System::IO;

namespace Face
{
	public ref class Aligner
	{
	public:
		Aligner();
		Aligner(String^ model_file_name);
		~Aligner();

		List<PointF>^ Align(Bitmap^ bmp, Rectangle^ face);

	private:
		seeta::PointDetector2* aligner = nullptr;
	};
}

