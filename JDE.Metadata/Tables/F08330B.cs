using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08330B - .
/// </summary>
public class F08330B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BTAN8.
        /// </summary>
        public const string BTAN8 = "BTAN8";

        /// <summary>
        /// BTPLAN.
        /// </summary>
        public const string BTPLAN = "BTPLAN";

        /// <summary>
        /// BTAOPT.
        /// </summary>
        public const string BTAOPT = "BTAOPT";

        /// <summary>
        /// BTEFT.
        /// </summary>
        public const string BTEFT = "BTEFT";

        /// <summary>
        /// BTEECD.
        /// </summary>
        public const string BTEECD = "BTEECD";

        /// <summary>
        /// BTEDTE.
        /// </summary>
        public const string BTEDTE = "BTEDTE";

        /// <summary>
        /// BTRTA1.
        /// </summary>
        public const string BTRTA1 = "BTRTA1";

        /// <summary>
        /// BTRTA2.
        /// </summary>
        public const string BTRTA2 = "BTRTA2";

        /// <summary>
        /// BTRTA3.
        /// </summary>
        public const string BTRTA3 = "BTRTA3";

        /// <summary>
        /// BTRTA4.
        /// </summary>
        public const string BTRTA4 = "BTRTA4";

        /// <summary>
        /// BTPID.
        /// </summary>
        public const string BTPID = "BTPID";

        /// <summary>
        /// BTUPMJ.
        /// </summary>
        public const string BTUPMJ = "BTUPMJ";

        /// <summary>
        /// BTJOBN.
        /// </summary>
        public const string BTJOBN = "BTJOBN";

        /// <summary>
        /// BTUSER.
        /// </summary>
        public const string BTUSER = "BTUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F08330B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BTAN8", "BTAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("BTPLAN", "BTPLAN", JdeDataType.String, 16, true, true),
        new JdeField("BTAOPT", "BTAOPT", JdeDataType.String, 6, true, true),
        new JdeField("BTEFT", "BTEFT", JdeDataType.Numeric, null, true, true),
        new JdeField("BTEECD", "BTEECD", JdeDataType.String, 6),
        new JdeField("BTEDTE", "BTEDTE", JdeDataType.Numeric),
        new JdeField("BTRTA1", "BTRTA1", JdeDataType.Numeric),
        new JdeField("BTRTA2", "BTRTA2", JdeDataType.Numeric),
        new JdeField("BTRTA3", "BTRTA3", JdeDataType.Numeric),
        new JdeField("BTRTA4", "BTRTA4", JdeDataType.Numeric),
        new JdeField("BTPID", "BTPID", JdeDataType.String, 20),
        new JdeField("BTUPMJ", "BTUPMJ", JdeDataType.Numeric),
        new JdeField("BTJOBN", "BTJOBN", JdeDataType.String, 20),
        new JdeField("BTUSER", "BTUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08330B_0", "Primary Key on BTAN8, BTEFT, BTPLAN, BTAOPT", new[] { "BTAN8", "BTEFT", "BTPLAN", "BTAOPT" }, isUnique: true, isPrimaryKey: true)
    };
}
