using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H590 - .
/// </summary>
public class F44H590 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CICWTMPT.
        /// </summary>
        public const string CICWTMPT = "CICWTMPT";

        /// <summary>
        /// CICLSRT.
        /// </summary>
        public const string CICLSRT = "CICLSRT";

        /// <summary>
        /// CICLDESC.
        /// </summary>
        public const string CICLDESC = "CICLDESC";

        /// <summary>
        /// CIMCU.
        /// </summary>
        public const string CIMCU = "CIMCU";

        /// <summary>
        /// CICLMCD.
        /// </summary>
        public const string CICLMCD = "CICLMCD";

        /// <summary>
        /// CIOBJ.
        /// </summary>
        public const string CIOBJ = "CIOBJ";

        /// <summary>
        /// CISUB.
        /// </summary>
        public const string CISUB = "CISUB";

        /// <summary>
        /// CILT.
        /// </summary>
        public const string CILT = "CILT";

        /// <summary>
        /// CIBDLT.
        /// </summary>
        public const string CIBDLT = "CIBDLT";

        /// <summary>
        /// CISBL.
        /// </summary>
        public const string CISBL = "CISBL";

        /// <summary>
        /// CISBLT.
        /// </summary>
        public const string CISBLT = "CISBLT";

        /// <summary>
        /// CICLSCD.
        /// </summary>
        public const string CICLSCD = "CICLSCD";

        /// <summary>
        /// CICLDBCR.
        /// </summary>
        public const string CICLDBCR = "CICLDBCR";

        /// <summary>
        /// CICLTAMT.
        /// </summary>
        public const string CICLTAMT = "CICLTAMT";

        /// <summary>
        /// CIAA.
        /// </summary>
        public const string CIAA = "CIAA";

        /// <summary>
        /// CIU.
        /// </summary>
        public const string CIU = "CIU";

        /// <summary>
        /// CICRTU.
        /// </summary>
        public const string CICRTU = "CICRTU";

        /// <summary>
        /// CICRTJ.
        /// </summary>
        public const string CICRTJ = "CICRTJ";

        /// <summary>
        /// CICRTT.
        /// </summary>
        public const string CICRTT = "CICRTT";

        /// <summary>
        /// CIWRKSTNID.
        /// </summary>
        public const string CIWRKSTNID = "CIWRKSTNID";

        /// <summary>
        /// CIHBOPID.
        /// </summary>
        public const string CIHBOPID = "CIHBOPID";

        /// <summary>
        /// CIUPMB.
        /// </summary>
        public const string CIUPMB = "CIUPMB";

        /// <summary>
        /// CIUPMJ.
        /// </summary>
        public const string CIUPMJ = "CIUPMJ";

        /// <summary>
        /// CIUPMT.
        /// </summary>
        public const string CIUPMT = "CIUPMT";

        /// <summary>
        /// CIJOBN.
        /// </summary>
        public const string CIJOBN = "CIJOBN";

        /// <summary>
        /// CIPID.
        /// </summary>
        public const string CIPID = "CIPID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H590";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CICWTMPT", "CICWTMPT", JdeDataType.String, 24, true, true),
        new JdeField("CICLSRT", "CICLSRT", JdeDataType.Numeric, null, true, true),
        new JdeField("CICLDESC", "CICLDESC", JdeDataType.String, 100),
        new JdeField("CIMCU", "CIMCU", JdeDataType.String, 24),
        new JdeField("CICLMCD", "CICLMCD", JdeDataType.String, 6),
        new JdeField("CIOBJ", "CIOBJ", JdeDataType.String, 12),
        new JdeField("CISUB", "CISUB", JdeDataType.String, 16),
        new JdeField("CILT", "CILT", JdeDataType.String, 4),
        new JdeField("CIBDLT", "CIBDLT", JdeDataType.String, 4),
        new JdeField("CISBL", "CISBL", JdeDataType.String, 16),
        new JdeField("CISBLT", "CISBLT", JdeDataType.String, 2),
        new JdeField("CICLSCD", "CICLSCD", JdeDataType.String, 6),
        new JdeField("CICLDBCR", "CICLDBCR", JdeDataType.String, 4),
        new JdeField("CICLTAMT", "CICLTAMT", JdeDataType.Numeric),
        new JdeField("CIAA", "CIAA", JdeDataType.Numeric),
        new JdeField("CIU", "CIU", JdeDataType.Numeric),
        new JdeField("CICRTU", "CICRTU", JdeDataType.String, 20),
        new JdeField("CICRTJ", "CICRTJ", JdeDataType.Numeric),
        new JdeField("CICRTT", "CICRTT", JdeDataType.Numeric),
        new JdeField("CIWRKSTNID", "CIWRKSTNID", JdeDataType.String, 20),
        new JdeField("CIHBOPID", "CIHBOPID", JdeDataType.String, 20),
        new JdeField("CIUPMB", "CIUPMB", JdeDataType.String, 20),
        new JdeField("CIUPMJ", "CIUPMJ", JdeDataType.Numeric),
        new JdeField("CIUPMT", "CIUPMT", JdeDataType.Numeric),
        new JdeField("CIJOBN", "CIJOBN", JdeDataType.String, 20),
        new JdeField("CIPID", "CIPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H590_0", "Primary Key on CICWTMPT, CICLSRT", new[] { "CICWTMPT", "CICLSRT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F44H590_2", "Index on CICWTMPT", new[] { "CICWTMPT" })
    };
}
