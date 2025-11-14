using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0118 - .
/// </summary>
public class F74U0118 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VHKCO.
        /// </summary>
        public const string VHKCO = "VHKCO";

        /// <summary>
        /// VHDOC.
        /// </summary>
        public const string VHDOC = "VHDOC";

        /// <summary>
        /// VHDCT.
        /// </summary>
        public const string VHDCT = "VHDCT";

        /// <summary>
        /// VHSFX.
        /// </summary>
        public const string VHSFX = "VHSFX";

        /// <summary>
        /// VHSFXE.
        /// </summary>
        public const string VHSFXE = "VHSFXE";

        /// <summary>
        /// VHEFTB.
        /// </summary>
        public const string VHEFTB = "VHEFTB";

        /// <summary>
        /// VHBEGT.
        /// </summary>
        public const string VHBEGT = "VHBEGT";

        /// <summary>
        /// VHUKTVPS.
        /// </summary>
        public const string VHUKTVPS = "VHUKTVPS";

        /// <summary>
        /// VHPST.
        /// </summary>
        public const string VHPST = "VHPST";

        /// <summary>
        /// VHEFTE.
        /// </summary>
        public const string VHEFTE = "VHEFTE";

        /// <summary>
        /// VHENDT.
        /// </summary>
        public const string VHENDT = "VHENDT";

        /// <summary>
        /// VHSTHR.
        /// </summary>
        public const string VHSTHR = "VHSTHR";

        /// <summary>
        /// VHCUMH.
        /// </summary>
        public const string VHCUMH = "VHCUMH";

        /// <summary>
        /// VHRMK.
        /// </summary>
        public const string VHRMK = "VHRMK";

        /// <summary>
        /// VHUKPSHA.
        /// </summary>
        public const string VHUKPSHA = "VHUKPSHA";

        /// <summary>
        /// VHUKPSHB.
        /// </summary>
        public const string VHUKPSHB = "VHUKPSHB";

        /// <summary>
        /// VHUKPSHC.
        /// </summary>
        public const string VHUKPSHC = "VHUKPSHC";

        /// <summary>
        /// VHUKPSHD.
        /// </summary>
        public const string VHUKPSHD = "VHUKPSHD";

        /// <summary>
        /// VHUKPSHE.
        /// </summary>
        public const string VHUKPSHE = "VHUKPSHE";

        /// <summary>
        /// VHUKPSHF.
        /// </summary>
        public const string VHUKPSHF = "VHUKPSHF";

        /// <summary>
        /// VHUSER.
        /// </summary>
        public const string VHUSER = "VHUSER";

        /// <summary>
        /// VHPID.
        /// </summary>
        public const string VHPID = "VHPID";

        /// <summary>
        /// VHUPMJ.
        /// </summary>
        public const string VHUPMJ = "VHUPMJ";

        /// <summary>
        /// VHUPMT.
        /// </summary>
        public const string VHUPMT = "VHUPMT";

        /// <summary>
        /// VHJOBN.
        /// </summary>
        public const string VHJOBN = "VHJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0118";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VHKCO", "VHKCO", JdeDataType.String, 10, true, true),
        new JdeField("VHDOC", "VHDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("VHDCT", "VHDCT", JdeDataType.String, 4, true, true),
        new JdeField("VHSFX", "VHSFX", JdeDataType.String, 6, true, true),
        new JdeField("VHSFXE", "VHSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("VHEFTB", "VHEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("VHBEGT", "VHBEGT", JdeDataType.Numeric, null, true, true),
        new JdeField("VHUKTVPS", "VHUKTVPS", JdeDataType.String, 2, true, true),
        new JdeField("VHPST", "VHPST", JdeDataType.String, 2),
        new JdeField("VHEFTE", "VHEFTE", JdeDataType.Numeric),
        new JdeField("VHENDT", "VHENDT", JdeDataType.Numeric),
        new JdeField("VHSTHR", "VHSTHR", JdeDataType.Numeric),
        new JdeField("VHCUMH", "VHCUMH", JdeDataType.Numeric),
        new JdeField("VHRMK", "VHRMK", JdeDataType.String, 60),
        new JdeField("VHUKPSHA", "VHUKPSHA", JdeDataType.String, 2),
        new JdeField("VHUKPSHB", "VHUKPSHB", JdeDataType.String, 2),
        new JdeField("VHUKPSHC", "VHUKPSHC", JdeDataType.String, 60),
        new JdeField("VHUKPSHD", "VHUKPSHD", JdeDataType.String, 20),
        new JdeField("VHUKPSHE", "VHUKPSHE", JdeDataType.Numeric),
        new JdeField("VHUKPSHF", "VHUKPSHF", JdeDataType.Numeric),
        new JdeField("VHUSER", "VHUSER", JdeDataType.String, 20),
        new JdeField("VHPID", "VHPID", JdeDataType.String, 20),
        new JdeField("VHUPMJ", "VHUPMJ", JdeDataType.Numeric),
        new JdeField("VHUPMT", "VHUPMT", JdeDataType.Numeric),
        new JdeField("VHJOBN", "VHJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0118_0", "Primary Key on VHKCO, VHDOC, VHDCT, VHSFX, VHSFXE, VHBEGT, VHEFTB, VHUKTVPS", new[] { "VHKCO", "VHDOC", "VHDCT", "VHSFX", "VHSFXE", "VHBEGT", "VHEFTB", "VHUKTVPS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U0118_2", "Index on VHKCO, VHDOC, VHDCT, VHSFX, VHSFXE", new[] { "VHKCO", "VHDOC", "VHDCT", "VHSFX", "VHSFXE" }),
        new JdeIndex("F74U0118_3", "Index on VHKCO, VHDOC, VHDCT, VHSFX, VHSFXE, VHEFTB, VHBEGT", new[] { "VHKCO", "VHDOC", "VHDCT", "VHSFX", "VHSFXE", "VHEFTB", "VHBEGT" })
    };
}
