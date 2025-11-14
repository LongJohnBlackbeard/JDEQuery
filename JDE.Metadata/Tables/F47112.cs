using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47112 - .
/// </summary>
public class F47112 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Z2EDTY.
        /// </summary>
        public const string Z2EDTY = "Z2EDTY";

        /// <summary>
        /// Z2EDSQ.
        /// </summary>
        public const string Z2EDSQ = "Z2EDSQ";

        /// <summary>
        /// Z2EKCO.
        /// </summary>
        public const string Z2EKCO = "Z2EKCO";

        /// <summary>
        /// Z2EDOC.
        /// </summary>
        public const string Z2EDOC = "Z2EDOC";

        /// <summary>
        /// Z2EDCT.
        /// </summary>
        public const string Z2EDCT = "Z2EDCT";

        /// <summary>
        /// Z2EDLN.
        /// </summary>
        public const string Z2EDLN = "Z2EDLN";

        /// <summary>
        /// Z2EDST.
        /// </summary>
        public const string Z2EDST = "Z2EDST";

        /// <summary>
        /// Z2EDFT.
        /// </summary>
        public const string Z2EDFT = "Z2EDFT";

        /// <summary>
        /// Z2EDDT.
        /// </summary>
        public const string Z2EDDT = "Z2EDDT";

        /// <summary>
        /// Z2EDER.
        /// </summary>
        public const string Z2EDER = "Z2EDER";

        /// <summary>
        /// Z2EDDL.
        /// </summary>
        public const string Z2EDDL = "Z2EDDL";

        /// <summary>
        /// Z2EDSP.
        /// </summary>
        public const string Z2EDSP = "Z2EDSP";

        /// <summary>
        /// Z2EDBT.
        /// </summary>
        public const string Z2EDBT = "Z2EDBT";

        /// <summary>
        /// Z2PNID.
        /// </summary>
        public const string Z2PNID = "Z2PNID";

        /// <summary>
        /// Z2DEPN.
        /// </summary>
        public const string Z2DEPN = "Z2DEPN";

        /// <summary>
        /// Z2VLDT.
        /// </summary>
        public const string Z2VLDT = "Z2VLDT";

        /// <summary>
        /// Z2DGJ.
        /// </summary>
        public const string Z2DGJ = "Z2DGJ";

        /// <summary>
        /// Z2VR01.
        /// </summary>
        public const string Z2VR01 = "Z2VR01";

        /// <summary>
        /// Z2DFIQ.
        /// </summary>
        public const string Z2DFIQ = "Z2DFIQ";

        /// <summary>
        /// Z2DFIX.
        /// </summary>
        public const string Z2DFIX = "Z2DFIX";

        /// <summary>
        /// Z2VR02.
        /// </summary>
        public const string Z2VR02 = "Z2VR02";

        /// <summary>
        /// Z2GLBA.
        /// </summary>
        public const string Z2GLBA = "Z2GLBA";

        /// <summary>
        /// Z2TTOT.
        /// </summary>
        public const string Z2TTOT = "Z2TTOT";

        /// <summary>
        /// Z2ICU.
        /// </summary>
        public const string Z2ICU = "Z2ICU";

        /// <summary>
        /// Z2ICUT.
        /// </summary>
        public const string Z2ICUT = "Z2ICUT";

        /// <summary>
        /// Z2DICJ.
        /// </summary>
        public const string Z2DICJ = "Z2DICJ";

        /// <summary>
        /// Z2URCD.
        /// </summary>
        public const string Z2URCD = "Z2URCD";

        /// <summary>
        /// Z2URDT.
        /// </summary>
        public const string Z2URDT = "Z2URDT";

        /// <summary>
        /// Z2URAT.
        /// </summary>
        public const string Z2URAT = "Z2URAT";

        /// <summary>
        /// Z2URAB.
        /// </summary>
        public const string Z2URAB = "Z2URAB";

        /// <summary>
        /// Z2URRF.
        /// </summary>
        public const string Z2URRF = "Z2URRF";

        /// <summary>
        /// Z2TORG.
        /// </summary>
        public const string Z2TORG = "Z2TORG";

        /// <summary>
        /// Z2USER.
        /// </summary>
        public const string Z2USER = "Z2USER";

        /// <summary>
        /// Z2PID.
        /// </summary>
        public const string Z2PID = "Z2PID";

        /// <summary>
        /// Z2JOBN.
        /// </summary>
        public const string Z2JOBN = "Z2JOBN";

        /// <summary>
        /// Z2UPMJ.
        /// </summary>
        public const string Z2UPMJ = "Z2UPMJ";

        /// <summary>
        /// Z2TDAY.
        /// </summary>
        public const string Z2TDAY = "Z2TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F47112";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Z2EDTY", "Z2EDTY", JdeDataType.String, 2),
        new JdeField("Z2EDSQ", "Z2EDSQ", JdeDataType.Numeric),
        new JdeField("Z2EKCO", "Z2EKCO", JdeDataType.String, 10, true, true),
        new JdeField("Z2EDOC", "Z2EDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("Z2EDCT", "Z2EDCT", JdeDataType.String, 4, true, true),
        new JdeField("Z2EDLN", "Z2EDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("Z2EDST", "Z2EDST", JdeDataType.String, 12),
        new JdeField("Z2EDFT", "Z2EDFT", JdeDataType.String, 20),
        new JdeField("Z2EDDT", "Z2EDDT", JdeDataType.Numeric),
        new JdeField("Z2EDER", "Z2EDER", JdeDataType.String, 2),
        new JdeField("Z2EDDL", "Z2EDDL", JdeDataType.Numeric),
        new JdeField("Z2EDSP", "Z2EDSP", JdeDataType.String, 2),
        new JdeField("Z2EDBT", "Z2EDBT", JdeDataType.String, 30),
        new JdeField("Z2PNID", "Z2PNID", JdeDataType.String, 30),
        new JdeField("Z2DEPN", "Z2DEPN", JdeDataType.String, 60),
        new JdeField("Z2VLDT", "Z2VLDT", JdeDataType.Numeric),
        new JdeField("Z2DGJ", "Z2DGJ", JdeDataType.Numeric),
        new JdeField("Z2VR01", "Z2VR01", JdeDataType.String, 50),
        new JdeField("Z2DFIQ", "Z2DFIQ", JdeDataType.String, 4),
        new JdeField("Z2DFIX", "Z2DFIX", JdeDataType.String, 24),
        new JdeField("Z2VR02", "Z2VR02", JdeDataType.String, 50),
        new JdeField("Z2GLBA", "Z2GLBA", JdeDataType.String, 16),
        new JdeField("Z2TTOT", "Z2TTOT", JdeDataType.Numeric),
        new JdeField("Z2ICU", "Z2ICU", JdeDataType.Numeric),
        new JdeField("Z2ICUT", "Z2ICUT", JdeDataType.String, 4),
        new JdeField("Z2DICJ", "Z2DICJ", JdeDataType.Numeric),
        new JdeField("Z2URCD", "Z2URCD", JdeDataType.String, 4),
        new JdeField("Z2URDT", "Z2URDT", JdeDataType.Numeric),
        new JdeField("Z2URAT", "Z2URAT", JdeDataType.Numeric),
        new JdeField("Z2URAB", "Z2URAB", JdeDataType.Numeric),
        new JdeField("Z2URRF", "Z2URRF", JdeDataType.String, 30),
        new JdeField("Z2TORG", "Z2TORG", JdeDataType.String, 20),
        new JdeField("Z2USER", "Z2USER", JdeDataType.String, 20),
        new JdeField("Z2PID", "Z2PID", JdeDataType.String, 20),
        new JdeField("Z2JOBN", "Z2JOBN", JdeDataType.String, 20),
        new JdeField("Z2UPMJ", "Z2UPMJ", JdeDataType.Numeric),
        new JdeField("Z2TDAY", "Z2TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47112_0", "Primary Key on Z2EDOC, Z2EDCT, Z2EKCO, Z2EDLN", new[] { "Z2EDOC", "Z2EDCT", "Z2EKCO", "Z2EDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
