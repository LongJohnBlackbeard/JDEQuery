using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F087711A - .
/// </summary>
public class F087711A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// XJTINC.
        /// </summary>
        public const string XJTINC = "XJTINC";

        /// <summary>
        /// XJANPA.
        /// </summary>
        public const string XJANPA = "XJANPA";

        /// <summary>
        /// XJAN8.
        /// </summary>
        public const string XJAN8 = "XJAN8";

        /// <summary>
        /// XJDEF.
        /// </summary>
        public const string XJDEF = "XJDEF";

        /// <summary>
        /// XJSERK.
        /// </summary>
        public const string XJSERK = "XJSERK";

        /// <summary>
        /// XJMSEB.
        /// </summary>
        public const string XJMSEB = "XJMSEB";

        /// <summary>
        /// XJUSER.
        /// </summary>
        public const string XJUSER = "XJUSER";

        /// <summary>
        /// XJPID.
        /// </summary>
        public const string XJPID = "XJPID";

        /// <summary>
        /// XJJOBN.
        /// </summary>
        public const string XJJOBN = "XJJOBN";

        /// <summary>
        /// XJUPMJ.
        /// </summary>
        public const string XJUPMJ = "XJUPMJ";

        /// <summary>
        /// XJUPMT.
        /// </summary>
        public const string XJUPMT = "XJUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F087711A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("XJTINC", "XJTINC", JdeDataType.String, 2, true, true),
        new JdeField("XJANPA", "XJANPA", JdeDataType.Numeric, null, true, true),
        new JdeField("XJAN8", "XJAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("XJDEF", "XJDEF", JdeDataType.Numeric, null, true, true),
        new JdeField("XJSERK", "XJSERK", JdeDataType.Numeric, null, true, true),
        new JdeField("XJMSEB", "XJMSEB", JdeDataType.String, 2),
        new JdeField("XJUSER", "XJUSER", JdeDataType.String, 20),
        new JdeField("XJPID", "XJPID", JdeDataType.String, 20),
        new JdeField("XJJOBN", "XJJOBN", JdeDataType.String, 20),
        new JdeField("XJUPMJ", "XJUPMJ", JdeDataType.Numeric),
        new JdeField("XJUPMT", "XJUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F087711A_0", "Primary Key on XJTINC, XJANPA, XJAN8, XJDEF, XJSERK", new[] { "XJTINC", "XJANPA", "XJAN8", "XJDEF", "XJSERK" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F087711A_2", "Index on SYS_NC00012$", new[] { "SYS_NC00012$" }),
        new JdeIndex("F087711A_3", "Index on XJTINC, XJANPA, XJAN8, XJDEF", new[] { "XJTINC", "XJANPA", "XJAN8", "XJDEF" }),
        new JdeIndex("F087711A_4", "Index on XJTINC, XJAN8, XJDEF", new[] { "XJTINC", "XJAN8", "XJDEF" })
    };
}
