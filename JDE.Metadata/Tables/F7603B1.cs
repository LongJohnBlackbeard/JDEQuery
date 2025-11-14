using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7603B1 - .
/// </summary>
public class F7603B1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CIDOC.
        /// </summary>
        public const string CIDOC = "CIDOC";

        /// <summary>
        /// CIDCT.
        /// </summary>
        public const string CIDCT = "CIDCT";

        /// <summary>
        /// CIKCO.
        /// </summary>
        public const string CIKCO = "CIKCO";

        /// <summary>
        /// CISFX.
        /// </summary>
        public const string CISFX = "CISFX";

        /// <summary>
        /// CIAN8.
        /// </summary>
        public const string CIAN8 = "CIAN8";

        /// <summary>
        /// CITXR1.
        /// </summary>
        public const string CITXR1 = "CITXR1";

        /// <summary>
        /// CIAA.
        /// </summary>
        public const string CIAA = "CIAA";

        /// <summary>
        /// CIJMSB.
        /// </summary>
        public const string CIJMSB = "CIJMSB";

        /// <summary>
        /// CIABRB.
        /// </summary>
        public const string CIABRB = "CIABRB";

        /// <summary>
        /// CIDIRB.
        /// </summary>
        public const string CIDIRB = "CIDIRB";

        /// <summary>
        /// CIAA1.
        /// </summary>
        public const string CIAA1 = "CIAA1";

        /// <summary>
        /// CIBBDN.
        /// </summary>
        public const string CIBBDN = "CIBBDN";

        /// <summary>
        /// CIBPIN.
        /// </summary>
        public const string CIBPIN = "CIBPIN";

        /// <summary>
        /// CIBPDA.
        /// </summary>
        public const string CIBPDA = "CIBPDA";

        /// <summary>
        /// CIINMG.
        /// </summary>
        public const string CIINMG = "CIINMG";

        /// <summary>
        /// CIBSCB.
        /// </summary>
        public const string CIBSCB = "CIBSCB";

        /// <summary>
        /// CIBRCB.
        /// </summary>
        public const string CIBRCB = "CIBRCB";

        /// <summary>
        /// CIBBSB.
        /// </summary>
        public const string CIBBSB = "CIBBSB";

        /// <summary>
        /// CIBKCD.
        /// </summary>
        public const string CIBKCD = "CIBKCD";

        /// <summary>
        /// CITORG.
        /// </summary>
        public const string CITORG = "CITORG";

        /// <summary>
        /// CIUSER.
        /// </summary>
        public const string CIUSER = "CIUSER";

        /// <summary>
        /// CIPID.
        /// </summary>
        public const string CIPID = "CIPID";

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
    }

    /// <inheritdoc />
    public override string TableName => "F7603B1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CIDOC", "CIDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("CIDCT", "CIDCT", JdeDataType.String, 4, true, true),
        new JdeField("CIKCO", "CIKCO", JdeDataType.String, 10, true, true),
        new JdeField("CISFX", "CISFX", JdeDataType.String, 6, true, true),
        new JdeField("CIAN8", "CIAN8", JdeDataType.Numeric),
        new JdeField("CITXR1", "CITXR1", JdeDataType.Numeric),
        new JdeField("CIAA", "CIAA", JdeDataType.Numeric),
        new JdeField("CIJMSB", "CIJMSB", JdeDataType.Numeric),
        new JdeField("CIABRB", "CIABRB", JdeDataType.Numeric),
        new JdeField("CIDIRB", "CIDIRB", JdeDataType.Numeric),
        new JdeField("CIAA1", "CIAA1", JdeDataType.Numeric),
        new JdeField("CIBBDN", "CIBBDN", JdeDataType.String, 30),
        new JdeField("CIBPIN", "CIBPIN", JdeDataType.Numeric),
        new JdeField("CIBPDA", "CIBPDA", JdeDataType.Numeric),
        new JdeField("CIINMG", "CIINMG", JdeDataType.String, 20),
        new JdeField("CIBSCB", "CIBSCB", JdeDataType.String, 4),
        new JdeField("CIBRCB", "CIBRCB", JdeDataType.String, 4),
        new JdeField("CIBBSB", "CIBBSB", JdeDataType.String, 2),
        new JdeField("CIBKCD", "CIBKCD", JdeDataType.String, 6),
        new JdeField("CITORG", "CITORG", JdeDataType.String, 20),
        new JdeField("CIUSER", "CIUSER", JdeDataType.String, 20),
        new JdeField("CIPID", "CIPID", JdeDataType.String, 20),
        new JdeField("CIUPMJ", "CIUPMJ", JdeDataType.Numeric),
        new JdeField("CIUPMT", "CIUPMT", JdeDataType.Numeric),
        new JdeField("CIJOBN", "CIJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7603B1_0", "Primary Key on CIDOC, CIDCT, CIKCO, CISFX", new[] { "CIDOC", "CIDCT", "CIKCO", "CISFX" }, isUnique: true, isPrimaryKey: true)
    };
}
