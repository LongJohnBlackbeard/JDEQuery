using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0100 - .
/// </summary>
public class F74U0100 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCUKDFLT.
        /// </summary>
        public const string CCUKDFLT = "CCUKDFLT";

        /// <summary>
        /// CCUKCIS.
        /// </summary>
        public const string CCUKCIS = "CCUKCIS";

        /// <summary>
        /// CCUKVOCR.
        /// </summary>
        public const string CCUKVOCR = "CCUKVOCR";

        /// <summary>
        /// CCUKCCTY.
        /// </summary>
        public const string CCUKCCTY = "CCUKCCTY";

        /// <summary>
        /// CCUKADCC.
        /// </summary>
        public const string CCUKADCC = "CCUKADCC";

        /// <summary>
        /// CCUKFLAB.
        /// </summary>
        public const string CCUKFLAB = "CCUKFLAB";

        /// <summary>
        /// CCUKOACC.
        /// </summary>
        public const string CCUKOACC = "CCUKOACC";

        /// <summary>
        /// CCUKOATL.
        /// </summary>
        public const string CCUKOATL = "CCUKOATL";

        /// <summary>
        /// CCUKNRCC.
        /// </summary>
        public const string CCUKNRCC = "CCUKNRCC";

        /// <summary>
        /// CCUKCCIV.
        /// </summary>
        public const string CCUKCCIV = "CCUKCCIV";

        /// <summary>
        /// CCUKICVC.
        /// </summary>
        public const string CCUKICVC = "CCUKICVC";

        /// <summary>
        /// CCUKNTXL.
        /// </summary>
        public const string CCUKNTXL = "CCUKNTXL";

        /// <summary>
        /// CCUKFER1.
        /// </summary>
        public const string CCUKFER1 = "CCUKFER1";

        /// <summary>
        /// CCUKEDII.
        /// </summary>
        public const string CCUKEDII = "CCUKEDII";

        /// <summary>
        /// CCUKFC1.
        /// </summary>
        public const string CCUKFC1 = "CCUKFC1";

        /// <summary>
        /// CCUKFC2.
        /// </summary>
        public const string CCUKFC2 = "CCUKFC2";

        /// <summary>
        /// CCUKFS1.
        /// </summary>
        public const string CCUKFS1 = "CCUKFS1";

        /// <summary>
        /// CCUKFS2.
        /// </summary>
        public const string CCUKFS2 = "CCUKFS2";

        /// <summary>
        /// CCUKFS3.
        /// </summary>
        public const string CCUKFS3 = "CCUKFS3";

        /// <summary>
        /// CCUKFS4.
        /// </summary>
        public const string CCUKFS4 = "CCUKFS4";

        /// <summary>
        /// CCUKFN1.
        /// </summary>
        public const string CCUKFN1 = "CCUKFN1";

        /// <summary>
        /// CCUKFN2.
        /// </summary>
        public const string CCUKFN2 = "CCUKFN2";

        /// <summary>
        /// CCUKFN3.
        /// </summary>
        public const string CCUKFN3 = "CCUKFN3";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCPID.
        /// </summary>
        public const string CCPID = "CCPID";

        /// <summary>
        /// CCUPMJ.
        /// </summary>
        public const string CCUPMJ = "CCUPMJ";

        /// <summary>
        /// CCUPMT.
        /// </summary>
        public const string CCUPMT = "CCUPMT";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0100";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCUKDFLT", "CCUKDFLT", JdeDataType.String, 2, true, true),
        new JdeField("CCUKCIS", "CCUKCIS", JdeDataType.String, 2),
        new JdeField("CCUKVOCR", "CCUKVOCR", JdeDataType.String, 2),
        new JdeField("CCUKCCTY", "CCUKCCTY", JdeDataType.String, 20),
        new JdeField("CCUKADCC", "CCUKADCC", JdeDataType.String, 4),
        new JdeField("CCUKFLAB", "CCUKFLAB", JdeDataType.String, 6),
        new JdeField("CCUKOACC", "CCUKOACC", JdeDataType.String, 4),
        new JdeField("CCUKOATL", "CCUKOATL", JdeDataType.String, 6),
        new JdeField("CCUKNRCC", "CCUKNRCC", JdeDataType.String, 2),
        new JdeField("CCUKCCIV", "CCUKCCIV", JdeDataType.String, 2),
        new JdeField("CCUKICVC", "CCUKICVC", JdeDataType.String, 2),
        new JdeField("CCUKNTXL", "CCUKNTXL", JdeDataType.String, 2),
        new JdeField("CCUKFER1", "CCUKFER1", JdeDataType.String, 2),
        new JdeField("CCUKEDII", "CCUKEDII", JdeDataType.String, 8),
        new JdeField("CCUKFC1", "CCUKFC1", JdeDataType.String, 2),
        new JdeField("CCUKFC2", "CCUKFC2", JdeDataType.String, 2),
        new JdeField("CCUKFS1", "CCUKFS1", JdeDataType.String, 6),
        new JdeField("CCUKFS2", "CCUKFS2", JdeDataType.String, 6),
        new JdeField("CCUKFS3", "CCUKFS3", JdeDataType.String, 20),
        new JdeField("CCUKFS4", "CCUKFS4", JdeDataType.String, 60),
        new JdeField("CCUKFN1", "CCUKFN1", JdeDataType.Numeric),
        new JdeField("CCUKFN2", "CCUKFN2", JdeDataType.Numeric),
        new JdeField("CCUKFN3", "CCUKFN3", JdeDataType.Numeric),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCPID", "CCPID", JdeDataType.String, 20),
        new JdeField("CCUPMJ", "CCUPMJ", JdeDataType.Numeric),
        new JdeField("CCUPMT", "CCUPMT", JdeDataType.Numeric),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0100_0", "Primary Key on CCUKDFLT", new[] { "CCUKDFLT" }, isUnique: true, isPrimaryKey: true)
    };
}
