using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F32922 - .
/// </summary>
public class F32922 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KVFCOD.
        /// </summary>
        public const string KVFCOD = "KVFCOD";

        /// <summary>
        /// KVKIT.
        /// </summary>
        public const string KVKIT = "KVKIT";

        /// <summary>
        /// KVMCU.
        /// </summary>
        public const string KVMCU = "KVMCU";

        /// <summary>
        /// KVATO#.
        /// </summary>
        public const string KVATO_ = "KVATO#";

        /// <summary>
        /// KVATOS.
        /// </summary>
        public const string KVATOS = "KVATOS";

        /// <summary>
        /// KVSRFV.
        /// </summary>
        public const string KVSRFV = "KVSRFV";

        /// <summary>
        /// KVSRTV.
        /// </summary>
        public const string KVSRTV = "KVSRTV";

        /// <summary>
        /// KVEFFF.
        /// </summary>
        public const string KVEFFF = "KVEFFF";

        /// <summary>
        /// KVEFFT.
        /// </summary>
        public const string KVEFFT = "KVEFFT";

        /// <summary>
        /// KVURCD.
        /// </summary>
        public const string KVURCD = "KVURCD";

        /// <summary>
        /// KVURDT.
        /// </summary>
        public const string KVURDT = "KVURDT";

        /// <summary>
        /// KVURAT.
        /// </summary>
        public const string KVURAT = "KVURAT";

        /// <summary>
        /// KVURAB.
        /// </summary>
        public const string KVURAB = "KVURAB";

        /// <summary>
        /// KVURRF.
        /// </summary>
        public const string KVURRF = "KVURRF";

        /// <summary>
        /// KVUSER.
        /// </summary>
        public const string KVUSER = "KVUSER";

        /// <summary>
        /// KVPID.
        /// </summary>
        public const string KVPID = "KVPID";

        /// <summary>
        /// KVJOBN.
        /// </summary>
        public const string KVJOBN = "KVJOBN";

        /// <summary>
        /// KVUPMJ.
        /// </summary>
        public const string KVUPMJ = "KVUPMJ";

        /// <summary>
        /// KVTDAY.
        /// </summary>
        public const string KVTDAY = "KVTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F32922";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KVFCOD", "KVFCOD", JdeDataType.String, 2, true, true),
        new JdeField("KVKIT", "KVKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("KVMCU", "KVMCU", JdeDataType.String, 24, true, true),
        new JdeField("KVATO#", "KVATO#", JdeDataType.Numeric, null, true, true),
        new JdeField("KVATOS", "KVATOS", JdeDataType.Numeric, null, true, true),
        new JdeField("KVSRFV", "KVSRFV", JdeDataType.String, 80, true, true),
        new JdeField("KVSRTV", "KVSRTV", JdeDataType.String, 80, true, true),
        new JdeField("KVEFFF", "KVEFFF", JdeDataType.Numeric),
        new JdeField("KVEFFT", "KVEFFT", JdeDataType.Numeric),
        new JdeField("KVURCD", "KVURCD", JdeDataType.String, 4),
        new JdeField("KVURDT", "KVURDT", JdeDataType.Numeric),
        new JdeField("KVURAT", "KVURAT", JdeDataType.Numeric),
        new JdeField("KVURAB", "KVURAB", JdeDataType.Numeric),
        new JdeField("KVURRF", "KVURRF", JdeDataType.String, 30),
        new JdeField("KVUSER", "KVUSER", JdeDataType.String, 20),
        new JdeField("KVPID", "KVPID", JdeDataType.String, 20),
        new JdeField("KVJOBN", "KVJOBN", JdeDataType.String, 20),
        new JdeField("KVUPMJ", "KVUPMJ", JdeDataType.Numeric),
        new JdeField("KVTDAY", "KVTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F32922_0", "Primary Key on KVFCOD, KVKIT, KVMCU, KVATO#, KVATOS, KVSRFV, KVSRTV", new[] { "KVFCOD", "KVKIT", "KVMCU", "KVATO#", "KVATOS", "KVSRFV", "KVSRTV" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F32922_2", "Index on KVKIT, KVMCU, KVATO#, KVATOS, KVSRFV, KVSRTV", new[] { "KVKIT", "KVMCU", "KVATO#", "KVATOS", "KVSRFV", "KVSRTV" })
    };
}
