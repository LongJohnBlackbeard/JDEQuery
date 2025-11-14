using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0417 - .
/// </summary>
public class F0417 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KBPYIN.
        /// </summary>
        public const string KBPYIN = "KBPYIN";

        /// <summary>
        /// KBGLBA.
        /// </summary>
        public const string KBGLBA = "KBGLBA";

        /// <summary>
        /// KBPGMP.
        /// </summary>
        public const string KBPGMP = "KBPGMP";

        /// <summary>
        /// KBPGMR.
        /// </summary>
        public const string KBPGMR = "KBPGMR";

        /// <summary>
        /// KBPGMA.
        /// </summary>
        public const string KBPGMA = "KBPGMA";

        /// <summary>
        /// KBPGMD.
        /// </summary>
        public const string KBPGMD = "KBPGMD";

        /// <summary>
        /// KBPVN.
        /// </summary>
        public const string KBPVN = "KBPVN";

        /// <summary>
        /// KBDVN.
        /// </summary>
        public const string KBDVN = "KBDVN";

        /// <summary>
        /// KBAVN.
        /// </summary>
        public const string KBAVN = "KBAVN";

        /// <summary>
        /// KBRVN.
        /// </summary>
        public const string KBRVN = "KBRVN";

        /// <summary>
        /// KBPID.
        /// </summary>
        public const string KBPID = "KBPID";

        /// <summary>
        /// KBUSER.
        /// </summary>
        public const string KBUSER = "KBUSER";

        /// <summary>
        /// KBJOBN.
        /// </summary>
        public const string KBJOBN = "KBJOBN";

        /// <summary>
        /// KBUPMJ.
        /// </summary>
        public const string KBUPMJ = "KBUPMJ";

        /// <summary>
        /// KBUPMT.
        /// </summary>
        public const string KBUPMT = "KBUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F0417";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KBPYIN", "KBPYIN", JdeDataType.String, 2, true, true),
        new JdeField("KBGLBA", "KBGLBA", JdeDataType.String, 16, true, true),
        new JdeField("KBPGMP", "KBPGMP", JdeDataType.String, 20),
        new JdeField("KBPGMR", "KBPGMR", JdeDataType.String, 20),
        new JdeField("KBPGMA", "KBPGMA", JdeDataType.String, 20),
        new JdeField("KBPGMD", "KBPGMD", JdeDataType.String, 20),
        new JdeField("KBPVN", "KBPVN", JdeDataType.String, 20),
        new JdeField("KBDVN", "KBDVN", JdeDataType.String, 20),
        new JdeField("KBAVN", "KBAVN", JdeDataType.String, 20),
        new JdeField("KBRVN", "KBRVN", JdeDataType.String, 20),
        new JdeField("KBPID", "KBPID", JdeDataType.String, 20),
        new JdeField("KBUSER", "KBUSER", JdeDataType.String, 20),
        new JdeField("KBJOBN", "KBJOBN", JdeDataType.String, 20),
        new JdeField("KBUPMJ", "KBUPMJ", JdeDataType.Numeric),
        new JdeField("KBUPMT", "KBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0417_0", "Primary Key on KBPYIN, KBGLBA", new[] { "KBPYIN", "KBGLBA" }, isUnique: true, isPrimaryKey: true)
    };
}
