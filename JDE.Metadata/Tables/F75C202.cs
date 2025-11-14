using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C202 - .
/// </summary>
public class F75C202 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DANUMB.
        /// </summary>
        public const string DANUMB = "DANUMB";

        /// <summary>
        /// DALT.
        /// </summary>
        public const string DALT = "DALT";

        /// <summary>
        /// DACHCD.
        /// </summary>
        public const string DACHCD = "DACHCD";

        /// <summary>
        /// DADOC.
        /// </summary>
        public const string DADOC = "DADOC";

        /// <summary>
        /// DADCT.
        /// </summary>
        public const string DADCT = "DADCT";

        /// <summary>
        /// DADGJ.
        /// </summary>
        public const string DADGJ = "DADGJ";

        /// <summary>
        /// DAKCO.
        /// </summary>
        public const string DAKCO = "DAKCO";

        /// <summary>
        /// DAJELN.
        /// </summary>
        public const string DAJELN = "DAJELN";

        /// <summary>
        /// DAEXTL.
        /// </summary>
        public const string DAEXTL = "DAEXTL";

        /// <summary>
        /// DAAA.
        /// </summary>
        public const string DAAA = "DAAA";

        /// <summary>
        /// DAFUTMATH1.
        /// </summary>
        public const string DAFUTMATH1 = "DAFUTMATH1";

        /// <summary>
        /// DAFUTSTR1.
        /// </summary>
        public const string DAFUTSTR1 = "DAFUTSTR1";

        /// <summary>
        /// DAFUTSTR2.
        /// </summary>
        public const string DAFUTSTR2 = "DAFUTSTR2";

        /// <summary>
        /// DAFUTDATE1.
        /// </summary>
        public const string DAFUTDATE1 = "DAFUTDATE1";

        /// <summary>
        /// DAFUTUO1.
        /// </summary>
        public const string DAFUTUO1 = "DAFUTUO1";

        /// <summary>
        /// DAUSER.
        /// </summary>
        public const string DAUSER = "DAUSER";

        /// <summary>
        /// DAPID.
        /// </summary>
        public const string DAPID = "DAPID";

        /// <summary>
        /// DAJOBN.
        /// </summary>
        public const string DAJOBN = "DAJOBN";

        /// <summary>
        /// DAUPMJ.
        /// </summary>
        public const string DAUPMJ = "DAUPMJ";

        /// <summary>
        /// DAUPMT.
        /// </summary>
        public const string DAUPMT = "DAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75C202";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DANUMB", "DANUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("DALT", "DALT", JdeDataType.String, 4, true, true),
        new JdeField("DACHCD", "DACHCD", JdeDataType.String, 2, true, true),
        new JdeField("DADOC", "DADOC", JdeDataType.Numeric, null, true, true),
        new JdeField("DADCT", "DADCT", JdeDataType.String, 4),
        new JdeField("DADGJ", "DADGJ", JdeDataType.Numeric),
        new JdeField("DAKCO", "DAKCO", JdeDataType.String, 10),
        new JdeField("DAJELN", "DAJELN", JdeDataType.Numeric),
        new JdeField("DAEXTL", "DAEXTL", JdeDataType.String, 4),
        new JdeField("DAAA", "DAAA", JdeDataType.Numeric),
        new JdeField("DAFUTMATH1", "DAFUTMATH1", JdeDataType.Numeric),
        new JdeField("DAFUTSTR1", "DAFUTSTR1", JdeDataType.String, 100),
        new JdeField("DAFUTSTR2", "DAFUTSTR2", JdeDataType.String, 100),
        new JdeField("DAFUTDATE1", "DAFUTDATE1", JdeDataType.Numeric),
        new JdeField("DAFUTUO1", "DAFUTUO1", JdeDataType.String, 2),
        new JdeField("DAUSER", "DAUSER", JdeDataType.String, 20),
        new JdeField("DAPID", "DAPID", JdeDataType.String, 20),
        new JdeField("DAJOBN", "DAJOBN", JdeDataType.String, 20),
        new JdeField("DAUPMJ", "DAUPMJ", JdeDataType.Numeric),
        new JdeField("DAUPMT", "DAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C202_0", "Primary Key on DANUMB, DALT, DACHCD, DADOC", new[] { "DANUMB", "DALT", "DACHCD", "DADOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75C202_2", "Index on DADOC, DADCT, DAKCO, DAJELN, DAEXTL, DALT, DADGJ", new[] { "DADOC", "DADCT", "DAKCO", "DAJELN", "DAEXTL", "DALT", "DADGJ" })
    };
}
