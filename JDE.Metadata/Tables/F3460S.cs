using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3460S - .
/// </summary>
public class F3460S : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MFITM.
        /// </summary>
        public const string MFITM = "MFITM";

        /// <summary>
        /// MFLITM.
        /// </summary>
        public const string MFLITM = "MFLITM";

        /// <summary>
        /// MFAITM.
        /// </summary>
        public const string MFAITM = "MFAITM";

        /// <summary>
        /// MFMCU.
        /// </summary>
        public const string MFMCU = "MFMCU";

        /// <summary>
        /// MFDRQJ.
        /// </summary>
        public const string MFDRQJ = "MFDRQJ";

        /// <summary>
        /// MFAN8.
        /// </summary>
        public const string MFAN8 = "MFAN8";

        /// <summary>
        /// MFUORG.
        /// </summary>
        public const string MFUORG = "MFUORG";

        /// <summary>
        /// MFAEXP.
        /// </summary>
        public const string MFAEXP = "MFAEXP";

        /// <summary>
        /// MFFAM.
        /// </summary>
        public const string MFFAM = "MFFAM";

        /// <summary>
        /// MFFQT.
        /// </summary>
        public const string MFFQT = "MFFQT";

        /// <summary>
        /// MFTYPF.
        /// </summary>
        public const string MFTYPF = "MFTYPF";

        /// <summary>
        /// MFDCTO.
        /// </summary>
        public const string MFDCTO = "MFDCTO";

        /// <summary>
        /// MFBPFC.
        /// </summary>
        public const string MFBPFC = "MFBPFC";

        /// <summary>
        /// MFRVIS.
        /// </summary>
        public const string MFRVIS = "MFRVIS";

        /// <summary>
        /// MFUPMJ.
        /// </summary>
        public const string MFUPMJ = "MFUPMJ";

        /// <summary>
        /// MFUSER.
        /// </summary>
        public const string MFUSER = "MFUSER";

        /// <summary>
        /// MFJOBN.
        /// </summary>
        public const string MFJOBN = "MFJOBN";

        /// <summary>
        /// MFPID.
        /// </summary>
        public const string MFPID = "MFPID";

        /// <summary>
        /// MFYR.
        /// </summary>
        public const string MFYR = "MFYR";

        /// <summary>
        /// MFTDAY.
        /// </summary>
        public const string MFTDAY = "MFTDAY";

        /// <summary>
        /// MFPMPN.
        /// </summary>
        public const string MFPMPN = "MFPMPN";

        /// <summary>
        /// MFPNS.
        /// </summary>
        public const string MFPNS = "MFPNS";
    }

    /// <inheritdoc />
    public override string TableName => "F3460S";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MFITM", "MFITM", JdeDataType.Numeric, null, true, true),
        new JdeField("MFLITM", "MFLITM", JdeDataType.String, 50),
        new JdeField("MFAITM", "MFAITM", JdeDataType.String, 50),
        new JdeField("MFMCU", "MFMCU", JdeDataType.String, 24, true, true),
        new JdeField("MFDRQJ", "MFDRQJ", JdeDataType.Numeric, null, true, true),
        new JdeField("MFAN8", "MFAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("MFUORG", "MFUORG", JdeDataType.Numeric),
        new JdeField("MFAEXP", "MFAEXP", JdeDataType.Numeric),
        new JdeField("MFFAM", "MFFAM", JdeDataType.Numeric),
        new JdeField("MFFQT", "MFFQT", JdeDataType.Numeric),
        new JdeField("MFTYPF", "MFTYPF", JdeDataType.String, 4, true, true),
        new JdeField("MFDCTO", "MFDCTO", JdeDataType.String, 4),
        new JdeField("MFBPFC", "MFBPFC", JdeDataType.String, 2),
        new JdeField("MFRVIS", "MFRVIS", JdeDataType.String, 2),
        new JdeField("MFUPMJ", "MFUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("MFUSER", "MFUSER", JdeDataType.String, 20),
        new JdeField("MFJOBN", "MFJOBN", JdeDataType.String, 20),
        new JdeField("MFPID", "MFPID", JdeDataType.String, 20),
        new JdeField("MFYR", "MFYR", JdeDataType.Numeric, null, true, true),
        new JdeField("MFTDAY", "MFTDAY", JdeDataType.Numeric, null, true, true),
        new JdeField("MFPMPN", "MFPMPN", JdeDataType.String, 60),
        new JdeField("MFPNS", "MFPNS", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3460S_0", "Primary Key on MFITM, MFMCU, MFDRQJ, MFTYPF, MFYR, MFAN8, MFUPMJ, MFTDAY", new[] { "MFITM", "MFMCU", "MFDRQJ", "MFTYPF", "MFYR", "MFAN8", "MFUPMJ", "MFTDAY" }, isUnique: true, isPrimaryKey: true)
    };
}
