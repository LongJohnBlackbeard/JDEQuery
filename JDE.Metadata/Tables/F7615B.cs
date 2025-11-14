using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7615B - .
/// </summary>
public class F7615B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TNBNOP.
        /// </summary>
        public const string TNBNOP = "TNBNOP";

        /// <summary>
        /// TNBSOP.
        /// </summary>
        public const string TNBSOP = "TNBSOP";

        /// <summary>
        /// TNDESC.
        /// </summary>
        public const string TNDESC = "TNDESC";

        /// <summary>
        /// TNBFII.
        /// </summary>
        public const string TNBFII = "TNBFII";

        /// <summary>
        /// TNBFIP.
        /// </summary>
        public const string TNBFIP = "TNBFIP";

        /// <summary>
        /// TNBFIS.
        /// </summary>
        public const string TNBFIS = "TNBFIS";

        /// <summary>
        /// TNBDIP.
        /// </summary>
        public const string TNBDIP = "TNBDIP";

        /// <summary>
        /// TNBIST.
        /// </summary>
        public const string TNBIST = "TNBIST";

        /// <summary>
        /// TNBST1.
        /// </summary>
        public const string TNBST1 = "TNBST1";

        /// <summary>
        /// TNICMS.
        /// </summary>
        public const string TNICMS = "TNICMS";

        /// <summary>
        /// TNUSER.
        /// </summary>
        public const string TNUSER = "TNUSER";

        /// <summary>
        /// TNPID.
        /// </summary>
        public const string TNPID = "TNPID";

        /// <summary>
        /// TNJOBN.
        /// </summary>
        public const string TNJOBN = "TNJOBN";

        /// <summary>
        /// TNUPMJ.
        /// </summary>
        public const string TNUPMJ = "TNUPMJ";

        /// <summary>
        /// TNTDAY.
        /// </summary>
        public const string TNTDAY = "TNTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F7615B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TNBNOP", "TNBNOP", JdeDataType.Numeric, null, true, true),
        new JdeField("TNBSOP", "TNBSOP", JdeDataType.String, 4, true, true),
        new JdeField("TNDESC", "TNDESC", JdeDataType.String, 60),
        new JdeField("TNBFII", "TNBFII", JdeDataType.String, 2),
        new JdeField("TNBFIP", "TNBFIP", JdeDataType.String, 2),
        new JdeField("TNBFIS", "TNBFIS", JdeDataType.String, 2),
        new JdeField("TNBDIP", "TNBDIP", JdeDataType.String, 8),
        new JdeField("TNBIST", "TNBIST", JdeDataType.String, 2),
        new JdeField("TNBST1", "TNBST1", JdeDataType.String, 6),
        new JdeField("TNICMS", "TNICMS", JdeDataType.String, 2),
        new JdeField("TNUSER", "TNUSER", JdeDataType.String, 20),
        new JdeField("TNPID", "TNPID", JdeDataType.String, 20),
        new JdeField("TNJOBN", "TNJOBN", JdeDataType.String, 20),
        new JdeField("TNUPMJ", "TNUPMJ", JdeDataType.Numeric),
        new JdeField("TNTDAY", "TNTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7615B_0", "Primary Key on TNBNOP, TNBSOP", new[] { "TNBNOP", "TNBSOP" }, isUnique: true, isPrimaryKey: true)
    };
}
