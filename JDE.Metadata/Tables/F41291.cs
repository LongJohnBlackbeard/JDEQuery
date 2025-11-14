using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41291 - .
/// </summary>
public class F41291 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IGPRP5.
        /// </summary>
        public const string IGPRP5 = "IGPRP5";

        /// <summary>
        /// IGITM.
        /// </summary>
        public const string IGITM = "IGITM";

        /// <summary>
        /// IGLITM.
        /// </summary>
        public const string IGLITM = "IGLITM";

        /// <summary>
        /// IGAITM.
        /// </summary>
        public const string IGAITM = "IGAITM";

        /// <summary>
        /// IGMCU.
        /// </summary>
        public const string IGMCU = "IGMCU";

        /// <summary>
        /// IGLOCN.
        /// </summary>
        public const string IGLOCN = "IGLOCN";

        /// <summary>
        /// IGLOTN.
        /// </summary>
        public const string IGLOTN = "IGLOTN";

        /// <summary>
        /// IGLVLA.
        /// </summary>
        public const string IGLVLA = "IGLVLA";

        /// <summary>
        /// IGLVLB.
        /// </summary>
        public const string IGLVLB = "IGLVLB";

        /// <summary>
        /// IGPCST.
        /// </summary>
        public const string IGPCST = "IGPCST";

        /// <summary>
        /// IGPAMT.
        /// </summary>
        public const string IGPAMT = "IGPAMT";

        /// <summary>
        /// IGRATF.
        /// </summary>
        public const string IGRATF = "IGRATF";

        /// <summary>
        /// IGRATV.
        /// </summary>
        public const string IGRATV = "IGRATV";

        /// <summary>
        /// IGAN8.
        /// </summary>
        public const string IGAN8 = "IGAN8";

        /// <summary>
        /// IGGLC.
        /// </summary>
        public const string IGGLC = "IGGLC";

        /// <summary>
        /// IGGLPT.
        /// </summary>
        public const string IGGLPT = "IGGLPT";

        /// <summary>
        /// IGEFFF.
        /// </summary>
        public const string IGEFFF = "IGEFFF";

        /// <summary>
        /// IGEFFT.
        /// </summary>
        public const string IGEFFT = "IGEFFT";

        /// <summary>
        /// IGTX.
        /// </summary>
        public const string IGTX = "IGTX";

        /// <summary>
        /// IGINYN.
        /// </summary>
        public const string IGINYN = "IGINYN";

        /// <summary>
        /// IGRCYN.
        /// </summary>
        public const string IGRCYN = "IGRCYN";

        /// <summary>
        /// IGAISL.
        /// </summary>
        public const string IGAISL = "IGAISL";

        /// <summary>
        /// IGBIN.
        /// </summary>
        public const string IGBIN = "IGBIN";

        /// <summary>
        /// IGUSER.
        /// </summary>
        public const string IGUSER = "IGUSER";

        /// <summary>
        /// IGJOBN.
        /// </summary>
        public const string IGJOBN = "IGJOBN";

        /// <summary>
        /// IGPID.
        /// </summary>
        public const string IGPID = "IGPID";

        /// <summary>
        /// IGUPMJ.
        /// </summary>
        public const string IGUPMJ = "IGUPMJ";

        /// <summary>
        /// IGTDAY.
        /// </summary>
        public const string IGTDAY = "IGTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F41291";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IGPRP5", "IGPRP5", JdeDataType.String, 6, true, true),
        new JdeField("IGITM", "IGITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IGLITM", "IGLITM", JdeDataType.String, 50),
        new JdeField("IGAITM", "IGAITM", JdeDataType.String, 50),
        new JdeField("IGMCU", "IGMCU", JdeDataType.String, 24, true, true),
        new JdeField("IGLOCN", "IGLOCN", JdeDataType.String, 40),
        new JdeField("IGLOTN", "IGLOTN", JdeDataType.String, 60),
        new JdeField("IGLVLA", "IGLVLA", JdeDataType.String, 6, true, true),
        new JdeField("IGLVLB", "IGLVLB", JdeDataType.String, 6),
        new JdeField("IGPCST", "IGPCST", JdeDataType.Numeric),
        new JdeField("IGPAMT", "IGPAMT", JdeDataType.Numeric),
        new JdeField("IGRATF", "IGRATF", JdeDataType.Numeric),
        new JdeField("IGRATV", "IGRATV", JdeDataType.Numeric),
        new JdeField("IGAN8", "IGAN8", JdeDataType.Numeric),
        new JdeField("IGGLC", "IGGLC", JdeDataType.String, 8),
        new JdeField("IGGLPT", "IGGLPT", JdeDataType.String, 8),
        new JdeField("IGEFFF", "IGEFFF", JdeDataType.Numeric),
        new JdeField("IGEFFT", "IGEFFT", JdeDataType.Numeric, null, true, true),
        new JdeField("IGTX", "IGTX", JdeDataType.String, 2),
        new JdeField("IGINYN", "IGINYN", JdeDataType.String, 2),
        new JdeField("IGRCYN", "IGRCYN", JdeDataType.String, 2),
        new JdeField("IGAISL", "IGAISL", JdeDataType.String, 16),
        new JdeField("IGBIN", "IGBIN", JdeDataType.String, 16),
        new JdeField("IGUSER", "IGUSER", JdeDataType.String, 20),
        new JdeField("IGJOBN", "IGJOBN", JdeDataType.String, 20),
        new JdeField("IGPID", "IGPID", JdeDataType.String, 20),
        new JdeField("IGUPMJ", "IGUPMJ", JdeDataType.Numeric),
        new JdeField("IGTDAY", "IGTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41291_0", "Primary Key on IGPRP5, IGITM, IGMCU, IGLVLA, IGEFFT", new[] { "IGPRP5", "IGITM", "IGMCU", "IGLVLA", "IGEFFT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F41291_2", "Index on IGITM, IGMCU, IGLVLA, IGEFFT", new[] { "IGITM", "IGMCU", "IGLVLA", "IGEFFT" }),
        new JdeIndex("F41291_3", "Index on IGPRP5, IGLVLA, IGEFFT", new[] { "IGPRP5", "IGLVLA", "IGEFFT" })
    };
}
