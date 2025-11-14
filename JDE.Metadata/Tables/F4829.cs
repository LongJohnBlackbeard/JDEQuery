using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4829 - .
/// </summary>
public class F4829 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DLDOCO.
        /// </summary>
        public const string DLDOCO = "DLDOCO";

        /// <summary>
        /// DLUKID.
        /// </summary>
        public const string DLUKID = "DLUKID";

        /// <summary>
        /// DLLCC1.
        /// </summary>
        public const string DLLCC1 = "DLLCC1";

        /// <summary>
        /// DLDELE.
        /// </summary>
        public const string DLDELE = "DLDELE";

        /// <summary>
        /// DLDVAN.
        /// </summary>
        public const string DLDVAN = "DLDVAN";

        /// <summary>
        /// DLDLDA.
        /// </summary>
        public const string DLDLDA = "DLDLDA";

        /// <summary>
        /// DLDLTM.
        /// </summary>
        public const string DLDLTM = "DLDLTM";

        /// <summary>
        /// DLURCD.
        /// </summary>
        public const string DLURCD = "DLURCD";

        /// <summary>
        /// DLURDT.
        /// </summary>
        public const string DLURDT = "DLURDT";

        /// <summary>
        /// DLURAT.
        /// </summary>
        public const string DLURAT = "DLURAT";

        /// <summary>
        /// DLURRF.
        /// </summary>
        public const string DLURRF = "DLURRF";

        /// <summary>
        /// DLURAB.
        /// </summary>
        public const string DLURAB = "DLURAB";

        /// <summary>
        /// DLUSER.
        /// </summary>
        public const string DLUSER = "DLUSER";

        /// <summary>
        /// DLPID.
        /// </summary>
        public const string DLPID = "DLPID";

        /// <summary>
        /// DLJOBN.
        /// </summary>
        public const string DLJOBN = "DLJOBN";

        /// <summary>
        /// DLUPMT.
        /// </summary>
        public const string DLUPMT = "DLUPMT";

        /// <summary>
        /// DLUPMJ.
        /// </summary>
        public const string DLUPMJ = "DLUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F4829";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DLDOCO", "DLDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("DLUKID", "DLUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("DLLCC1", "DLLCC1", JdeDataType.String, 20),
        new JdeField("DLDELE", "DLDELE", JdeDataType.String, 600),
        new JdeField("DLDVAN", "DLDVAN", JdeDataType.Numeric),
        new JdeField("DLDLDA", "DLDLDA", JdeDataType.Numeric),
        new JdeField("DLDLTM", "DLDLTM", JdeDataType.Numeric),
        new JdeField("DLURCD", "DLURCD", JdeDataType.String, 4),
        new JdeField("DLURDT", "DLURDT", JdeDataType.Numeric),
        new JdeField("DLURAT", "DLURAT", JdeDataType.Numeric),
        new JdeField("DLURRF", "DLURRF", JdeDataType.String, 30),
        new JdeField("DLURAB", "DLURAB", JdeDataType.Numeric),
        new JdeField("DLUSER", "DLUSER", JdeDataType.String, 20),
        new JdeField("DLPID", "DLPID", JdeDataType.String, 20),
        new JdeField("DLJOBN", "DLJOBN", JdeDataType.String, 20),
        new JdeField("DLUPMT", "DLUPMT", JdeDataType.Numeric),
        new JdeField("DLUPMJ", "DLUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4829_0", "Primary Key on DLDOCO, DLUKID", new[] { "DLDOCO", "DLUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
