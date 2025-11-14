using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D315 - .
/// </summary>
public class F80D315 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ASALERTINS.
        /// </summary>
        public const string ASALERTINS = "ASALERTINS";

        /// <summary>
        /// ASLNID.
        /// </summary>
        public const string ASLNID = "ASLNID";

        /// <summary>
        /// ASALERTSTS.
        /// </summary>
        public const string ASALERTSTS = "ASALERTSTS";

        /// <summary>
        /// ASURCD.
        /// </summary>
        public const string ASURCD = "ASURCD";

        /// <summary>
        /// ASURDT.
        /// </summary>
        public const string ASURDT = "ASURDT";

        /// <summary>
        /// ASURAT.
        /// </summary>
        public const string ASURAT = "ASURAT";

        /// <summary>
        /// ASURAB.
        /// </summary>
        public const string ASURAB = "ASURAB";

        /// <summary>
        /// ASURRF.
        /// </summary>
        public const string ASURRF = "ASURRF";

        /// <summary>
        /// ASUSER.
        /// </summary>
        public const string ASUSER = "ASUSER";

        /// <summary>
        /// ASMKEY.
        /// </summary>
        public const string ASMKEY = "ASMKEY";

        /// <summary>
        /// ASPID.
        /// </summary>
        public const string ASPID = "ASPID";

        /// <summary>
        /// ASUUPMJ.
        /// </summary>
        public const string ASUUPMJ = "ASUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F80D315";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ASALERTINS", "ASALERTINS", JdeDataType.Numeric, null, true, true),
        new JdeField("ASLNID", "ASLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("ASALERTSTS", "ASALERTSTS", JdeDataType.String, 2),
        new JdeField("ASURCD", "ASURCD", JdeDataType.String, 4),
        new JdeField("ASURDT", "ASURDT", JdeDataType.Numeric),
        new JdeField("ASURAT", "ASURAT", JdeDataType.Numeric),
        new JdeField("ASURAB", "ASURAB", JdeDataType.Numeric),
        new JdeField("ASURRF", "ASURRF", JdeDataType.String, 30),
        new JdeField("ASUSER", "ASUSER", JdeDataType.String, 20),
        new JdeField("ASMKEY", "ASMKEY", JdeDataType.String, 30),
        new JdeField("ASPID", "ASPID", JdeDataType.String, 20),
        new JdeField("ASUUPMJ", "ASUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D315_0", "Primary Key on ASALERTINS, ASLNID", new[] { "ASALERTINS", "ASLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F80D315_2", "Index on ASALERTINS, SYS_NC00013$", new[] { "ASALERTINS", "SYS_NC00013$" })
    };
}
