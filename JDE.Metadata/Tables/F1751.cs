using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1751 - .
/// </summary>
public class F1751 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GSDCTO.
        /// </summary>
        public const string GSDCTO = "GSDCTO";

        /// <summary>
        /// GSCALLQ.
        /// </summary>
        public const string GSCALLQ = "GSCALLQ";

        /// <summary>
        /// GSCT01.
        /// </summary>
        public const string GSCT01 = "GSCT01";

        /// <summary>
        /// GSCLST.
        /// </summary>
        public const string GSCLST = "GSCLST";

        /// <summary>
        /// GSCLSTA.
        /// </summary>
        public const string GSCLSTA = "GSCLSTA";

        /// <summary>
        /// GSCLST1.
        /// </summary>
        public const string GSCLST1 = "GSCLST1";

        /// <summary>
        /// GSCLST2.
        /// </summary>
        public const string GSCLST2 = "GSCLST2";

        /// <summary>
        /// GSCLST3.
        /// </summary>
        public const string GSCLST3 = "GSCLST3";

        /// <summary>
        /// GSCLST4.
        /// </summary>
        public const string GSCLST4 = "GSCLST4";

        /// <summary>
        /// GSCLST5.
        /// </summary>
        public const string GSCLST5 = "GSCLST5";

        /// <summary>
        /// GSCLBH1.
        /// </summary>
        public const string GSCLBH1 = "GSCLBH1";

        /// <summary>
        /// GSCLBH2.
        /// </summary>
        public const string GSCLBH2 = "GSCLBH2";

        /// <summary>
        /// GSCLBH3.
        /// </summary>
        public const string GSCLBH3 = "GSCLBH3";

        /// <summary>
        /// GSCLBH4.
        /// </summary>
        public const string GSCLBH4 = "GSCLBH4";

        /// <summary>
        /// GSCLBH5.
        /// </summary>
        public const string GSCLBH5 = "GSCLBH5";

        /// <summary>
        /// GSUSER.
        /// </summary>
        public const string GSUSER = "GSUSER";

        /// <summary>
        /// GSUPMJ.
        /// </summary>
        public const string GSUPMJ = "GSUPMJ";

        /// <summary>
        /// GSUPMT.
        /// </summary>
        public const string GSUPMT = "GSUPMT";

        /// <summary>
        /// GSJOBN.
        /// </summary>
        public const string GSJOBN = "GSJOBN";

        /// <summary>
        /// GSPID.
        /// </summary>
        public const string GSPID = "GSPID";
    }

    /// <inheritdoc />
    public override string TableName => "F1751";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GSDCTO", "GSDCTO", JdeDataType.String, 4, true, true),
        new JdeField("GSCALLQ", "GSCALLQ", JdeDataType.Numeric, null, true, true),
        new JdeField("GSCT01", "GSCT01", JdeDataType.String, 2, true, true),
        new JdeField("GSCLST", "GSCLST", JdeDataType.String, 6, true, true),
        new JdeField("GSCLSTA", "GSCLSTA", JdeDataType.String, 6),
        new JdeField("GSCLST1", "GSCLST1", JdeDataType.String, 6),
        new JdeField("GSCLST2", "GSCLST2", JdeDataType.String, 6),
        new JdeField("GSCLST3", "GSCLST3", JdeDataType.String, 6),
        new JdeField("GSCLST4", "GSCLST4", JdeDataType.String, 6),
        new JdeField("GSCLST5", "GSCLST5", JdeDataType.String, 6),
        new JdeField("GSCLBH1", "GSCLBH1", JdeDataType.String, 2),
        new JdeField("GSCLBH2", "GSCLBH2", JdeDataType.String, 2),
        new JdeField("GSCLBH3", "GSCLBH3", JdeDataType.String, 2),
        new JdeField("GSCLBH4", "GSCLBH4", JdeDataType.String, 2),
        new JdeField("GSCLBH5", "GSCLBH5", JdeDataType.String, 2),
        new JdeField("GSUSER", "GSUSER", JdeDataType.String, 20),
        new JdeField("GSUPMJ", "GSUPMJ", JdeDataType.Numeric),
        new JdeField("GSUPMT", "GSUPMT", JdeDataType.Numeric),
        new JdeField("GSJOBN", "GSJOBN", JdeDataType.String, 20),
        new JdeField("GSPID", "GSPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1751_0", "Primary Key on GSDCTO, GSCALLQ, GSCT01, GSCLST", new[] { "GSDCTO", "GSCALLQ", "GSCT01", "GSCLST" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1751_3", "Index on GSCALLQ, GSCT01", new[] { "GSCALLQ", "GSCT01" })
    };
}
