using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43221 - .
/// </summary>
public class F43221 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RZCO.
        /// </summary>
        public const string RZCO = "RZCO";

        /// <summary>
        /// RZAN8.
        /// </summary>
        public const string RZAN8 = "RZAN8";

        /// <summary>
        /// RZPTAT.
        /// </summary>
        public const string RZPTAT = "RZPTAT";

        /// <summary>
        /// RZNTAT.
        /// </summary>
        public const string RZNTAT = "RZNTAT";

        /// <summary>
        /// RZUSER.
        /// </summary>
        public const string RZUSER = "RZUSER";

        /// <summary>
        /// RZPID.
        /// </summary>
        public const string RZPID = "RZPID";

        /// <summary>
        /// RZJOBN.
        /// </summary>
        public const string RZJOBN = "RZJOBN";

        /// <summary>
        /// RZUPMJ.
        /// </summary>
        public const string RZUPMJ = "RZUPMJ";

        /// <summary>
        /// RZUPMT.
        /// </summary>
        public const string RZUPMT = "RZUPMT";

        /// <summary>
        /// RZURAT.
        /// </summary>
        public const string RZURAT = "RZURAT";

        /// <summary>
        /// RZURRF.
        /// </summary>
        public const string RZURRF = "RZURRF";

        /// <summary>
        /// RZURCD.
        /// </summary>
        public const string RZURCD = "RZURCD";

        /// <summary>
        /// RZURAB.
        /// </summary>
        public const string RZURAB = "RZURAB";

        /// <summary>
        /// RZURDT.
        /// </summary>
        public const string RZURDT = "RZURDT";
    }

    /// <inheritdoc />
    public override string TableName => "F43221";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RZCO", "RZCO", JdeDataType.String, 10, true, true),
        new JdeField("RZAN8", "RZAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RZPTAT", "RZPTAT", JdeDataType.Numeric),
        new JdeField("RZNTAT", "RZNTAT", JdeDataType.Numeric),
        new JdeField("RZUSER", "RZUSER", JdeDataType.String, 20),
        new JdeField("RZPID", "RZPID", JdeDataType.String, 20),
        new JdeField("RZJOBN", "RZJOBN", JdeDataType.String, 20),
        new JdeField("RZUPMJ", "RZUPMJ", JdeDataType.Numeric),
        new JdeField("RZUPMT", "RZUPMT", JdeDataType.Numeric),
        new JdeField("RZURAT", "RZURAT", JdeDataType.Numeric),
        new JdeField("RZURRF", "RZURRF", JdeDataType.String, 30),
        new JdeField("RZURCD", "RZURCD", JdeDataType.String, 4),
        new JdeField("RZURAB", "RZURAB", JdeDataType.Numeric),
        new JdeField("RZURDT", "RZURDT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43221_0", "Primary Key on RZCO, RZAN8", new[] { "RZCO", "RZAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
