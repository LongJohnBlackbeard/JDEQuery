using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F77101 - .
/// </summary>
public class F77101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JAYEID.
        /// </summary>
        public const string JAYEID = "JAYEID";

        /// <summary>
        /// JATAXYR.
        /// </summary>
        public const string JATAXYR = "JATAXYR";

        /// <summary>
        /// JAFMTE.
        /// </summary>
        public const string JAFMTE = "JAFMTE";

        /// <summary>
        /// JASEQ.
        /// </summary>
        public const string JASEQ = "JASEQ";

        /// <summary>
        /// JARTID.
        /// </summary>
        public const string JARTID = "JARTID";

        /// <summary>
        /// JARTVE.
        /// </summary>
        public const string JARTVE = "JARTVE";

        /// <summary>
        /// JADL01.
        /// </summary>
        public const string JADL01 = "JADL01";

        /// <summary>
        /// JAW2P1.
        /// </summary>
        public const string JAW2P1 = "JAW2P1";

        /// <summary>
        /// JASL.
        /// </summary>
        public const string JASL = "JASL";

        /// <summary>
        /// JAUSER.
        /// </summary>
        public const string JAUSER = "JAUSER";

        /// <summary>
        /// JAPID.
        /// </summary>
        public const string JAPID = "JAPID";

        /// <summary>
        /// JAUPMJ.
        /// </summary>
        public const string JAUPMJ = "JAUPMJ";

        /// <summary>
        /// JAUPMT.
        /// </summary>
        public const string JAUPMT = "JAUPMT";

        /// <summary>
        /// JAJOBN.
        /// </summary>
        public const string JAJOBN = "JAJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F77101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JAYEID", "JAYEID", JdeDataType.String, 20, true, true),
        new JdeField("JATAXYR", "JATAXYR", JdeDataType.Numeric, null, true, true),
        new JdeField("JAFMTE", "JAFMTE", JdeDataType.String, 2, true, true),
        new JdeField("JASEQ", "JASEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("JARTID", "JARTID", JdeDataType.String, 20, true, true),
        new JdeField("JARTVE", "JARTVE", JdeDataType.String, 20, true, true),
        new JdeField("JADL01", "JADL01", JdeDataType.String, 60),
        new JdeField("JAW2P1", "JAW2P1", JdeDataType.Numeric),
        new JdeField("JASL", "JASL", JdeDataType.String, 40),
        new JdeField("JAUSER", "JAUSER", JdeDataType.String, 20),
        new JdeField("JAPID", "JAPID", JdeDataType.String, 20),
        new JdeField("JAUPMJ", "JAUPMJ", JdeDataType.Numeric),
        new JdeField("JAUPMT", "JAUPMT", JdeDataType.Numeric),
        new JdeField("JAJOBN", "JAJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F77101_0", "Primary Key on JAYEID, JATAXYR, JAFMTE, JASEQ, JARTID, JARTVE", new[] { "JAYEID", "JATAXYR", "JAFMTE", "JASEQ", "JARTID", "JARTVE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F77101_2", "Index on JAYEID, JATAXYR, JAFMTE, JARTID, JARTVE", new[] { "JAYEID", "JATAXYR", "JAFMTE", "JARTID", "JARTVE" })
    };
}
