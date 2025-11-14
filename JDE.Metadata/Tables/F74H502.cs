using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74H502 - .
/// </summary>
public class F74H502 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TFDOC.
        /// </summary>
        public const string TFDOC = "TFDOC";

        /// <summary>
        /// TFDCT.
        /// </summary>
        public const string TFDCT = "TFDCT";

        /// <summary>
        /// TFKCO.
        /// </summary>
        public const string TFKCO = "TFKCO";

        /// <summary>
        /// TFK74FLEN.
        /// </summary>
        public const string TFK74FLEN = "TFK74FLEN";

        /// <summary>
        /// TFDIVJ.
        /// </summary>
        public const string TFDIVJ = "TFDIVJ";

        /// <summary>
        /// TFK74DPD.
        /// </summary>
        public const string TFK74DPD = "TFK74DPD";

        /// <summary>
        /// TFDGJ.
        /// </summary>
        public const string TFDGJ = "TFDGJ";

        /// <summary>
        /// TFAN8.
        /// </summary>
        public const string TFAN8 = "TFAN8";

        /// <summary>
        /// TFH74INVST.
        /// </summary>
        public const string TFH74INVST = "TFH74INVST";

        /// <summary>
        /// TFSY.
        /// </summary>
        public const string TFSY = "TFSY";

        /// <summary>
        /// TFUSER.
        /// </summary>
        public const string TFUSER = "TFUSER";

        /// <summary>
        /// TFPID.
        /// </summary>
        public const string TFPID = "TFPID";

        /// <summary>
        /// TFJOBN.
        /// </summary>
        public const string TFJOBN = "TFJOBN";

        /// <summary>
        /// TFUPMJ.
        /// </summary>
        public const string TFUPMJ = "TFUPMJ";

        /// <summary>
        /// TFUPMT.
        /// </summary>
        public const string TFUPMT = "TFUPMT";

        /// <summary>
        /// TFH74FUTDT.
        /// </summary>
        public const string TFH74FUTDT = "TFH74FUTDT";

        /// <summary>
        /// TFH74FUTNM.
        /// </summary>
        public const string TFH74FUTNM = "TFH74FUTNM";

        /// <summary>
        /// TFFUT6.
        /// </summary>
        public const string TFFUT6 = "TFFUT6";

        /// <summary>
        /// TFX2.
        /// </summary>
        public const string TFX2 = "TFX2";

        /// <summary>
        /// TFH74FUTCH.
        /// </summary>
        public const string TFH74FUTCH = "TFH74FUTCH";

        /// <summary>
        /// TFH74MSSG.
        /// </summary>
        public const string TFH74MSSG = "TFH74MSSG";
    }

    /// <inheritdoc />
    public override string TableName => "F74H502";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TFDOC", "TFDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("TFDCT", "TFDCT", JdeDataType.String, 4, true, true),
        new JdeField("TFKCO", "TFKCO", JdeDataType.String, 10, true, true),
        new JdeField("TFK74FLEN", "TFK74FLEN", JdeDataType.String, 50),
        new JdeField("TFDIVJ", "TFDIVJ", JdeDataType.Numeric),
        new JdeField("TFK74DPD", "TFK74DPD", JdeDataType.Numeric),
        new JdeField("TFDGJ", "TFDGJ", JdeDataType.Numeric),
        new JdeField("TFAN8", "TFAN8", JdeDataType.Numeric),
        new JdeField("TFH74INVST", "TFH74INVST", JdeDataType.String, 2),
        new JdeField("TFSY", "TFSY", JdeDataType.String, 8),
        new JdeField("TFUSER", "TFUSER", JdeDataType.String, 20),
        new JdeField("TFPID", "TFPID", JdeDataType.String, 20),
        new JdeField("TFJOBN", "TFJOBN", JdeDataType.String, 20),
        new JdeField("TFUPMJ", "TFUPMJ", JdeDataType.Numeric),
        new JdeField("TFUPMT", "TFUPMT", JdeDataType.Numeric),
        new JdeField("TFH74FUTDT", "TFH74FUTDT", JdeDataType.Numeric),
        new JdeField("TFH74FUTNM", "TFH74FUTNM", JdeDataType.Numeric),
        new JdeField("TFFUT6", "TFFUT6", JdeDataType.String, 60),
        new JdeField("TFX2", "TFX2", JdeDataType.String, 2),
        new JdeField("TFH74FUTCH", "TFH74FUTCH", JdeDataType.String, 2),
        new JdeField("TFH74MSSG", "TFH74MSSG", JdeDataType.String, 2048)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74H502_0", "Primary Key on TFDOC, TFDCT, TFKCO", new[] { "TFDOC", "TFDCT", "TFKCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74H502_2", "Index on TFK74FLEN, TFKCO", new[] { "TFK74FLEN", "TFKCO" })
    };
}
