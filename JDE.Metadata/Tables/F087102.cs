using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F087102 - .
/// </summary>
public class F087102 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TLTSKCD.
        /// </summary>
        public const string TLTSKCD = "TLTSKCD";

        /// <summary>
        /// TLTSKTY.
        /// </summary>
        public const string TLTSKTY = "TLTSKTY";

        /// <summary>
        /// TLSBCL.
        /// </summary>
        public const string TLSBCL = "TLSBCL";

        /// <summary>
        /// TLTSKD2.
        /// </summary>
        public const string TLTSKD2 = "TLTSKD2";

        /// <summary>
        /// TLTSKR.
        /// </summary>
        public const string TLTSKR = "TLTSKR";

        /// <summary>
        /// TLRQL.
        /// </summary>
        public const string TLRQL = "TLRQL";

        /// <summary>
        /// TLUPMJ.
        /// </summary>
        public const string TLUPMJ = "TLUPMJ";

        /// <summary>
        /// TLUSER.
        /// </summary>
        public const string TLUSER = "TLUSER";

        /// <summary>
        /// TLJOBN.
        /// </summary>
        public const string TLJOBN = "TLJOBN";

        /// <summary>
        /// TLPID.
        /// </summary>
        public const string TLPID = "TLPID";

        /// <summary>
        /// TLTSKOW.
        /// </summary>
        public const string TLTSKOW = "TLTSKOW";

        /// <summary>
        /// TLENDS.
        /// </summary>
        public const string TLENDS = "TLENDS";

        /// <summary>
        /// TLTSKAR.
        /// </summary>
        public const string TLTSKAR = "TLTSKAR";

        /// <summary>
        /// TLANM.
        /// </summary>
        public const string TLANM = "TLANM";
    }

    /// <inheritdoc />
    public override string TableName => "F087102";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TLTSKCD", "TLTSKCD", JdeDataType.Numeric, null, true, true),
        new JdeField("TLTSKTY", "TLTSKTY", JdeDataType.String, 20),
        new JdeField("TLSBCL", "TLSBCL", JdeDataType.String, 20),
        new JdeField("TLTSKD2", "TLTSKD2", JdeDataType.String, 80),
        new JdeField("TLTSKR", "TLTSKR", JdeDataType.Numeric),
        new JdeField("TLRQL", "TLRQL", JdeDataType.Numeric),
        new JdeField("TLUPMJ", "TLUPMJ", JdeDataType.Numeric),
        new JdeField("TLUSER", "TLUSER", JdeDataType.String, 20),
        new JdeField("TLJOBN", "TLJOBN", JdeDataType.String, 20),
        new JdeField("TLPID", "TLPID", JdeDataType.String, 20),
        new JdeField("TLTSKOW", "TLTSKOW", JdeDataType.Numeric),
        new JdeField("TLENDS", "TLENDS", JdeDataType.String, 4),
        new JdeField("TLTSKAR", "TLTSKAR", JdeDataType.String, 2),
        new JdeField("TLANM", "TLANM", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F087102_0", "Primary Key on TLTSKCD", new[] { "TLTSKCD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F087102_2", "Unique Index on TLTSKTY, TLSBCL", new[] { "TLTSKTY", "TLSBCL" }, isUnique: true),
        new JdeIndex("F087102_3", "Index on TLTSKOW, TLTSKCD", new[] { "TLTSKOW", "TLTSKCD" })
    };
}
