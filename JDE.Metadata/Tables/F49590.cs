using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49590 - .
/// </summary>
public class F49590 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DBBN01.
        /// </summary>
        public const string DBBN01 = "DBBN01";

        /// <summary>
        /// DBMCUZ.
        /// </summary>
        public const string DBMCUZ = "DBMCUZ";

        /// <summary>
        /// DBDPCR.
        /// </summary>
        public const string DBDPCR = "DBDPCR";

        /// <summary>
        /// DBDCRT.
        /// </summary>
        public const string DBDCRT = "DBDCRT";

        /// <summary>
        /// DBPGM.
        /// </summary>
        public const string DBPGM = "DBPGM";

        /// <summary>
        /// DBVERS.
        /// </summary>
        public const string DBVERS = "DBVERS";

        /// <summary>
        /// DBDTDO.
        /// </summary>
        public const string DBDTDO = "DBDTDO";

        /// <summary>
        /// DBSDPC.
        /// </summary>
        public const string DBSDPC = "DBSDPC";

        /// <summary>
        /// DBDASF.
        /// </summary>
        public const string DBDASF = "DBDASF";

        /// <summary>
        /// DBNXT2.
        /// </summary>
        public const string DBNXT2 = "DBNXT2";

        /// <summary>
        /// DBUSER.
        /// </summary>
        public const string DBUSER = "DBUSER";

        /// <summary>
        /// DBPID.
        /// </summary>
        public const string DBPID = "DBPID";

        /// <summary>
        /// DBJOBN.
        /// </summary>
        public const string DBJOBN = "DBJOBN";

        /// <summary>
        /// DBUPMJ.
        /// </summary>
        public const string DBUPMJ = "DBUPMJ";

        /// <summary>
        /// DBTDAY.
        /// </summary>
        public const string DBTDAY = "DBTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49590";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DBBN01", "DBBN01", JdeDataType.Numeric, null, true, true),
        new JdeField("DBMCUZ", "DBMCUZ", JdeDataType.String, 24),
        new JdeField("DBDPCR", "DBDPCR", JdeDataType.String, 2),
        new JdeField("DBDCRT", "DBDCRT", JdeDataType.String, 4),
        new JdeField("DBPGM", "DBPGM", JdeDataType.String, 20),
        new JdeField("DBVERS", "DBVERS", JdeDataType.String, 20),
        new JdeField("DBDTDO", "DBDTDO", JdeDataType.Numeric),
        new JdeField("DBSDPC", "DBSDPC", JdeDataType.String, 2),
        new JdeField("DBDASF", "DBDASF", JdeDataType.String, 2),
        new JdeField("DBNXT2", "DBNXT2", JdeDataType.String, 6),
        new JdeField("DBUSER", "DBUSER", JdeDataType.String, 20),
        new JdeField("DBPID", "DBPID", JdeDataType.String, 20),
        new JdeField("DBJOBN", "DBJOBN", JdeDataType.String, 20),
        new JdeField("DBUPMJ", "DBUPMJ", JdeDataType.Numeric),
        new JdeField("DBTDAY", "DBTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49590_0", "Primary Key on DBBN01", new[] { "DBBN01" }, isUnique: true, isPrimaryKey: true)
    };
}
