using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F52G86 - .
/// </summary>
public class F52G86 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BRIPBR.
        /// </summary>
        public const string BRIPBR = "BRIPBR";

        /// <summary>
        /// BRBRDL.
        /// </summary>
        public const string BRBRDL = "BRBRDL";

        /// <summary>
        /// BRBUCA.
        /// </summary>
        public const string BRBUCA = "BRBUCA";

        /// <summary>
        /// BRBCDL.
        /// </summary>
        public const string BRBCDL = "BRBCDL";

        /// <summary>
        /// BRBCSR.
        /// </summary>
        public const string BRBCSR = "BRBCSR";

        /// <summary>
        /// BRBCSEQ.
        /// </summary>
        public const string BRBCSEQ = "BRBCSEQ";

        /// <summary>
        /// BRUSER.
        /// </summary>
        public const string BRUSER = "BRUSER";

        /// <summary>
        /// BRPID.
        /// </summary>
        public const string BRPID = "BRPID";

        /// <summary>
        /// BRMKEY.
        /// </summary>
        public const string BRMKEY = "BRMKEY";

        /// <summary>
        /// BRUPMJ.
        /// </summary>
        public const string BRUPMJ = "BRUPMJ";

        /// <summary>
        /// BRUPMT.
        /// </summary>
        public const string BRUPMT = "BRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F52G86";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BRIPBR", "BRIPBR", JdeDataType.String, 8, true, true),
        new JdeField("BRBRDL", "BRBRDL", JdeDataType.String, 60),
        new JdeField("BRBUCA", "BRBUCA", JdeDataType.String, 10, true, true),
        new JdeField("BRBCDL", "BRBCDL", JdeDataType.String, 60),
        new JdeField("BRBCSR", "BRBCSR", JdeDataType.String, 2),
        new JdeField("BRBCSEQ", "BRBCSEQ", JdeDataType.Numeric),
        new JdeField("BRUSER", "BRUSER", JdeDataType.String, 20),
        new JdeField("BRPID", "BRPID", JdeDataType.String, 20),
        new JdeField("BRMKEY", "BRMKEY", JdeDataType.String, 30),
        new JdeField("BRUPMJ", "BRUPMJ", JdeDataType.Numeric),
        new JdeField("BRUPMT", "BRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F52G86_0", "Primary Key on BRIPBR, BRBUCA", new[] { "BRIPBR", "BRBUCA" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F52G86_2", "Index on BRIPBR, BRBCSEQ", new[] { "BRIPBR", "BRBCSEQ" })
    };
}
