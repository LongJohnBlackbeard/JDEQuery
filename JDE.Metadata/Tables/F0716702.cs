using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0716702 - .
/// </summary>
public class F0716702 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EATSKID.
        /// </summary>
        public const string EATSKID = "EATSKID";

        /// <summary>
        /// EAEAEFDT.
        /// </summary>
        public const string EAEAEFDT = "EAEAEFDT";

        /// <summary>
        /// EAPDBA.
        /// </summary>
        public const string EAPDBA = "EAPDBA";

        /// <summary>
        /// EAEAPAYRT.
        /// </summary>
        public const string EAEAPAYRT = "EAEAPAYRT";

        /// <summary>
        /// EAEARTRT.
        /// </summary>
        public const string EAEARTRT = "EAEARTRT";

        /// <summary>
        /// EAEARTRTF.
        /// </summary>
        public const string EAEARTRTF = "EAEARTRTF";

        /// <summary>
        /// EABLGRT.
        /// </summary>
        public const string EABLGRT = "EABLGRT";

        /// <summary>
        /// EAFBLGRT.
        /// </summary>
        public const string EAFBLGRT = "EAFBLGRT";

        /// <summary>
        /// EAUM.
        /// </summary>
        public const string EAUM = "EAUM";

        /// <summary>
        /// EACRR.
        /// </summary>
        public const string EACRR = "EACRR";

        /// <summary>
        /// EAERDT.
        /// </summary>
        public const string EAERDT = "EAERDT";

        /// <summary>
        /// EAEAURCH3.
        /// </summary>
        public const string EAEAURCH3 = "EAEAURCH3";

        /// <summary>
        /// EAEAURST8.
        /// </summary>
        public const string EAEAURST8 = "EAEAURST8";

        /// <summary>
        /// EAEAURMN3.
        /// </summary>
        public const string EAEAURMN3 = "EAEAURMN3";

        /// <summary>
        /// EAEAURCU3.
        /// </summary>
        public const string EAEAURCU3 = "EAEAURCU3";

        /// <summary>
        /// EAEAURDT3.
        /// </summary>
        public const string EAEAURDT3 = "EAEAURDT3";

        /// <summary>
        /// EAUSER.
        /// </summary>
        public const string EAUSER = "EAUSER";

        /// <summary>
        /// EAPID.
        /// </summary>
        public const string EAPID = "EAPID";

        /// <summary>
        /// EAJOBN.
        /// </summary>
        public const string EAJOBN = "EAJOBN";

        /// <summary>
        /// EAUPMJ.
        /// </summary>
        public const string EAUPMJ = "EAUPMJ";

        /// <summary>
        /// EAUPMT.
        /// </summary>
        public const string EAUPMT = "EAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F0716702";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EATSKID", "EATSKID", JdeDataType.Numeric, null, true, true),
        new JdeField("EAEAEFDT", "EAEAEFDT", JdeDataType.Numeric, null, true, true),
        new JdeField("EAPDBA", "EAPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("EAEAPAYRT", "EAEAPAYRT", JdeDataType.Numeric),
        new JdeField("EAEARTRT", "EAEARTRT", JdeDataType.Numeric),
        new JdeField("EAEARTRTF", "EAEARTRTF", JdeDataType.Numeric),
        new JdeField("EABLGRT", "EABLGRT", JdeDataType.Numeric),
        new JdeField("EAFBLGRT", "EAFBLGRT", JdeDataType.Numeric),
        new JdeField("EAUM", "EAUM", JdeDataType.String, 4),
        new JdeField("EACRR", "EACRR", JdeDataType.Numeric),
        new JdeField("EAERDT", "EAERDT", JdeDataType.Numeric),
        new JdeField("EAEAURCH3", "EAEAURCH3", JdeDataType.String, 2),
        new JdeField("EAEAURST8", "EAEAURST8", JdeDataType.String, 60),
        new JdeField("EAEAURMN3", "EAEAURMN3", JdeDataType.Numeric),
        new JdeField("EAEAURCU3", "EAEAURCU3", JdeDataType.Numeric),
        new JdeField("EAEAURDT3", "EAEAURDT3", JdeDataType.Numeric),
        new JdeField("EAUSER", "EAUSER", JdeDataType.String, 20),
        new JdeField("EAPID", "EAPID", JdeDataType.String, 20),
        new JdeField("EAJOBN", "EAJOBN", JdeDataType.String, 20),
        new JdeField("EAUPMJ", "EAUPMJ", JdeDataType.Numeric),
        new JdeField("EAUPMT", "EAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0716702_0", "Primary Key on EATSKID, EAEAEFDT, EAPDBA", new[] { "EATSKID", "EAEAEFDT", "EAPDBA" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0716702_2", "Index on EATSKID, SYS_NC00022$, EAPDBA", new[] { "EATSKID", "SYS_NC00022$", "EAPDBA" })
    };
}
