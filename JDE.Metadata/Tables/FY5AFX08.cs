using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FY5AFX08 - .
/// </summary>
public class FY5AFX08 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DIY5AFTMPL.
        /// </summary>
        public const string DIY5AFTMPL = "DIY5AFTMPL";

        /// <summary>
        /// DIDL01.
        /// </summary>
        public const string DIDL01 = "DIDL01";

        /// <summary>
        /// DIY5AFTPLV.
        /// </summary>
        public const string DIY5AFTPLV = "DIY5AFTPLV";

        /// <summary>
        /// DIY5AFMSTR.
        /// </summary>
        public const string DIY5AFMSTR = "DIY5AFMSTR";

        /// <summary>
        /// DIY5AFLOCK.
        /// </summary>
        public const string DIY5AFLOCK = "DIY5AFLOCK";

        /// <summary>
        /// DIY5AFINCL.
        /// </summary>
        public const string DIY5AFINCL = "DIY5AFINCL";

        /// <summary>
        /// DIY5AF1A.
        /// </summary>
        public const string DIY5AF1A = "DIY5AF1A";

        /// <summary>
        /// DIY5AF1C.
        /// </summary>
        public const string DIY5AF1C = "DIY5AF1C";

        /// <summary>
        /// DIY5AF1CPY.
        /// </summary>
        public const string DIY5AF1CPY = "DIY5AF1CPY";

        /// <summary>
        /// DIY5AF1D.
        /// </summary>
        public const string DIY5AF1D = "DIY5AF1D";

        /// <summary>
        /// DIY5AF1O.
        /// </summary>
        public const string DIY5AF1O = "DIY5AF1O";

        /// <summary>
        /// DIY5AF1S.
        /// </summary>
        public const string DIY5AF1S = "DIY5AF1S";

        /// <summary>
        /// DIY5AF2A.
        /// </summary>
        public const string DIY5AF2A = "DIY5AF2A";

        /// <summary>
        /// DIY5AF2C.
        /// </summary>
        public const string DIY5AF2C = "DIY5AF2C";

        /// <summary>
        /// DIY5AF2V.
        /// </summary>
        public const string DIY5AF2V = "DIY5AF2V";

        /// <summary>
        /// DIY5AF3I.
        /// </summary>
        public const string DIY5AF3I = "DIY5AF3I";

        /// <summary>
        /// DIY5AF3R.
        /// </summary>
        public const string DIY5AF3R = "DIY5AF3R";

        /// <summary>
        /// DIY5AF4A.
        /// </summary>
        public const string DIY5AF4A = "DIY5AF4A";

        /// <summary>
        /// DIY5AF4C.
        /// </summary>
        public const string DIY5AF4C = "DIY5AF4C";

        /// <summary>
        /// DIY5AF4D.
        /// </summary>
        public const string DIY5AF4D = "DIY5AF4D";

        /// <summary>
        /// DIY5AF4V.
        /// </summary>
        public const string DIY5AF4V = "DIY5AF4V";

        /// <summary>
        /// DIY5AF5C.
        /// </summary>
        public const string DIY5AF5C = "DIY5AF5C";

        /// <summary>
        /// DIY5AF5PDS.
        /// </summary>
        public const string DIY5AF5PDS = "DIY5AF5PDS";

        /// <summary>
        /// DIY5AF5PVL.
        /// </summary>
        public const string DIY5AF5PVL = "DIY5AF5PVL";

        /// <summary>
        /// DIY5AF5PVR.
        /// </summary>
        public const string DIY5AF5PVR = "DIY5AF5PVR";

        /// <summary>
        /// DIY5AF6R.
        /// </summary>
        public const string DIY5AF6R = "DIY5AF6R";

        /// <summary>
        /// DIY5AF7R.
        /// </summary>
        public const string DIY5AF7R = "DIY5AF7R";

        /// <summary>
        /// DIY5AF8C.
        /// </summary>
        public const string DIY5AF8C = "DIY5AF8C";

        /// <summary>
        /// DIY5AF8V.
        /// </summary>
        public const string DIY5AF8V = "DIY5AF8V";

        /// <summary>
        /// DIY5AF9R.
        /// </summary>
        public const string DIY5AF9R = "DIY5AF9R";

        /// <summary>
        /// DIY5AFLBUS.
        /// </summary>
        public const string DIY5AFLBUS = "DIY5AFLBUS";

        /// <summary>
        /// DICRTU.
        /// </summary>
        public const string DICRTU = "DICRTU";

        /// <summary>
        /// DICADT.
        /// </summary>
        public const string DICADT = "DICADT";

        /// <summary>
        /// DIMUSE.
        /// </summary>
        public const string DIMUSE = "DIMUSE";

        /// <summary>
        /// DIPID.
        /// </summary>
        public const string DIPID = "DIPID";

        /// <summary>
        /// DIJOBN.
        /// </summary>
        public const string DIJOBN = "DIJOBN";

        /// <summary>
        /// DIUPMJ.
        /// </summary>
        public const string DIUPMJ = "DIUPMJ";

        /// <summary>
        /// DIUPMT.
        /// </summary>
        public const string DIUPMT = "DIUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "FY5AFX08";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DIY5AFTMPL", "DIY5AFTMPL", JdeDataType.String, 20, true, true),
        new JdeField("DIDL01", "DIDL01", JdeDataType.String, 60),
        new JdeField("DIY5AFTPLV", "DIY5AFTPLV", JdeDataType.String, 2),
        new JdeField("DIY5AFMSTR", "DIY5AFMSTR", JdeDataType.String, 20),
        new JdeField("DIY5AFLOCK", "DIY5AFLOCK", JdeDataType.String, 2),
        new JdeField("DIY5AFINCL", "DIY5AFINCL", JdeDataType.String, 2),
        new JdeField("DIY5AF1A", "DIY5AF1A", JdeDataType.String, 2),
        new JdeField("DIY5AF1C", "DIY5AF1C", JdeDataType.String, 2),
        new JdeField("DIY5AF1CPY", "DIY5AF1CPY", JdeDataType.String, 2),
        new JdeField("DIY5AF1D", "DIY5AF1D", JdeDataType.String, 2),
        new JdeField("DIY5AF1O", "DIY5AF1O", JdeDataType.String, 2),
        new JdeField("DIY5AF1S", "DIY5AF1S", JdeDataType.String, 2),
        new JdeField("DIY5AF2A", "DIY5AF2A", JdeDataType.String, 2),
        new JdeField("DIY5AF2C", "DIY5AF2C", JdeDataType.String, 2),
        new JdeField("DIY5AF2V", "DIY5AF2V", JdeDataType.String, 2),
        new JdeField("DIY5AF3I", "DIY5AF3I", JdeDataType.String, 2),
        new JdeField("DIY5AF3R", "DIY5AF3R", JdeDataType.String, 2),
        new JdeField("DIY5AF4A", "DIY5AF4A", JdeDataType.String, 2),
        new JdeField("DIY5AF4C", "DIY5AF4C", JdeDataType.String, 2),
        new JdeField("DIY5AF4D", "DIY5AF4D", JdeDataType.String, 2),
        new JdeField("DIY5AF4V", "DIY5AF4V", JdeDataType.String, 2),
        new JdeField("DIY5AF5C", "DIY5AF5C", JdeDataType.String, 2),
        new JdeField("DIY5AF5PDS", "DIY5AF5PDS", JdeDataType.String, 2),
        new JdeField("DIY5AF5PVL", "DIY5AF5PVL", JdeDataType.String, 2),
        new JdeField("DIY5AF5PVR", "DIY5AF5PVR", JdeDataType.String, 2),
        new JdeField("DIY5AF6R", "DIY5AF6R", JdeDataType.String, 2),
        new JdeField("DIY5AF7R", "DIY5AF7R", JdeDataType.String, 2),
        new JdeField("DIY5AF8C", "DIY5AF8C", JdeDataType.String, 2),
        new JdeField("DIY5AF8V", "DIY5AF8V", JdeDataType.String, 2),
        new JdeField("DIY5AF9R", "DIY5AF9R", JdeDataType.String, 2),
        new JdeField("DIY5AFLBUS", "DIY5AFLBUS", JdeDataType.String, 20),
        new JdeField("DICRTU", "DICRTU", JdeDataType.String, 20),
        new JdeField("DICADT", "DICADT", JdeDataType.Numeric),
        new JdeField("DIMUSE", "DIMUSE", JdeDataType.String, 20),
        new JdeField("DIPID", "DIPID", JdeDataType.String, 20),
        new JdeField("DIJOBN", "DIJOBN", JdeDataType.String, 20),
        new JdeField("DIUPMJ", "DIUPMJ", JdeDataType.Numeric),
        new JdeField("DIUPMT", "DIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FY5AFX08_0", "Primary Key on DIY5AFTMPL", new[] { "DIY5AFTMPL" }, isUnique: true, isPrimaryKey: true)
    };
}
