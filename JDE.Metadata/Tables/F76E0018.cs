using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76E0018 - .
/// </summary>
public class F76E0018 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TDJOBS.
        /// </summary>
        public const string TDJOBS = "TDJOBS";

        /// <summary>
        /// TDCTID.
        /// </summary>
        public const string TDCTID = "TDCTID";

        /// <summary>
        /// TDKCOO.
        /// </summary>
        public const string TDKCOO = "TDKCOO";

        /// <summary>
        /// TDDCTO.
        /// </summary>
        public const string TDDCTO = "TDDCTO";

        /// <summary>
        /// TDDOCO.
        /// </summary>
        public const string TDDOCO = "TDDOCO";

        /// <summary>
        /// TDSFXO.
        /// </summary>
        public const string TDSFXO = "TDSFXO";

        /// <summary>
        /// TDLNID.
        /// </summary>
        public const string TDLNID = "TDLNID";

        /// <summary>
        /// TDICUT.
        /// </summary>
        public const string TDICUT = "TDICUT";

        /// <summary>
        /// TDICU.
        /// </summary>
        public const string TDICU = "TDICU";

        /// <summary>
        /// TDUPMJ.
        /// </summary>
        public const string TDUPMJ = "TDUPMJ";

        /// <summary>
        /// TDUPMT.
        /// </summary>
        public const string TDUPMT = "TDUPMT";

        /// <summary>
        /// TDPID.
        /// </summary>
        public const string TDPID = "TDPID";

        /// <summary>
        /// TDUSER.
        /// </summary>
        public const string TDUSER = "TDUSER";

        /// <summary>
        /// TDJOBN.
        /// </summary>
        public const string TDJOBN = "TDJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76E0018";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TDJOBS", "TDJOBS", JdeDataType.Numeric),
        new JdeField("TDCTID", "TDCTID", JdeDataType.String, 30),
        new JdeField("TDKCOO", "TDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("TDDCTO", "TDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("TDDOCO", "TDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("TDSFXO", "TDSFXO", JdeDataType.String, 6, true, true),
        new JdeField("TDLNID", "TDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("TDICUT", "TDICUT", JdeDataType.String, 4),
        new JdeField("TDICU", "TDICU", JdeDataType.Numeric),
        new JdeField("TDUPMJ", "TDUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("TDUPMT", "TDUPMT", JdeDataType.Numeric, null, true, true),
        new JdeField("TDPID", "TDPID", JdeDataType.String, 20),
        new JdeField("TDUSER", "TDUSER", JdeDataType.String, 20),
        new JdeField("TDJOBN", "TDJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76E0018_0", "Primary Key on TDDOCO, TDDCTO, TDKCOO, TDSFXO, TDLNID, TDUPMJ, TDUPMT", new[] { "TDDOCO", "TDDCTO", "TDKCOO", "TDSFXO", "TDLNID", "TDUPMJ", "TDUPMT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76E0018_2", "Index on TDCTID, TDJOBS", new[] { "TDCTID", "TDJOBS" })
    };
}
