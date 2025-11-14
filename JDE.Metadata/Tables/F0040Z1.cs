using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0040Z1 - .
/// </summary>
public class F0040Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZBCTID.
        /// </summary>
        public const string ZBCTID = "ZBCTID";

        /// <summary>
        /// ZBTRNM.
        /// </summary>
        public const string ZBTRNM = "ZBTRNM";

        /// <summary>
        /// ZBTRNY.
        /// </summary>
        public const string ZBTRNY = "ZBTRNY";

        /// <summary>
        /// ZBTRNK.
        /// </summary>
        public const string ZBTRNK = "ZBTRNK";

        /// <summary>
        /// ZBEDTL.
        /// </summary>
        public const string ZBEDTL = "ZBEDTL";

        /// <summary>
        /// ZBSERK.
        /// </summary>
        public const string ZBSERK = "ZBSERK";

        /// <summary>
        /// ZBPID.
        /// </summary>
        public const string ZBPID = "ZBPID";

        /// <summary>
        /// ZBFILE.
        /// </summary>
        public const string ZBFILE = "ZBFILE";

        /// <summary>
        /// ZBDTAI.
        /// </summary>
        public const string ZBDTAI = "ZBDTAI";

        /// <summary>
        /// ZBERNO.
        /// </summary>
        public const string ZBERNO = "ZBERNO";

        /// <summary>
        /// ZBFDVL.
        /// </summary>
        public const string ZBFDVL = "ZBFDVL";

        /// <summary>
        /// ZBDLTC.
        /// </summary>
        public const string ZBDLTC = "ZBDLTC";
    }

    /// <inheritdoc />
    public override string TableName => "F0040Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZBCTID", "ZBCTID", JdeDataType.String, 30, true, true),
        new JdeField("ZBTRNM", "ZBTRNM", JdeDataType.String, 30, true, true),
        new JdeField("ZBTRNY", "ZBTRNY", JdeDataType.String, 4, true, true),
        new JdeField("ZBTRNK", "ZBTRNK", JdeDataType.String, 44, true, true),
        new JdeField("ZBEDTL", "ZBEDTL", JdeDataType.String, 40, true, true),
        new JdeField("ZBSERK", "ZBSERK", JdeDataType.Numeric),
        new JdeField("ZBPID", "ZBPID", JdeDataType.String, 20, true, true),
        new JdeField("ZBFILE", "ZBFILE", JdeDataType.String, 20, true, true),
        new JdeField("ZBDTAI", "ZBDTAI", JdeDataType.String, 20, true, true),
        new JdeField("ZBERNO", "ZBERNO", JdeDataType.String, 8, true, true),
        new JdeField("ZBFDVL", "ZBFDVL", JdeDataType.String, 80),
        new JdeField("ZBDLTC", "ZBDLTC", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0040Z1_0", "Primary Key on ZBCTID, ZBTRNM, ZBTRNY, ZBTRNK, ZBEDTL, ZBPID, ZBFILE, ZBDTAI, ZBERNO", new[] { "ZBCTID", "ZBTRNM", "ZBTRNY", "ZBTRNK", "ZBEDTL", "ZBPID", "ZBFILE", "ZBDTAI", "ZBERNO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0040Z1_2", "Index on ZBSERK, ZBTRNM", new[] { "ZBSERK", "ZBTRNM" })
    };
}
