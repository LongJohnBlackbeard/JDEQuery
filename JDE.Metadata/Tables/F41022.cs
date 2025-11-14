using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41022 - .
/// </summary>
public class F41022 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PNMCU.
        /// </summary>
        public const string PNMCU = "PNMCU";

        /// <summary>
        /// PNITM.
        /// </summary>
        public const string PNITM = "PNITM";

        /// <summary>
        /// PNSTVL.
        /// </summary>
        public const string PNSTVL = "PNSTVL";

        /// <summary>
        /// PNBUM0.
        /// </summary>
        public const string PNBUM0 = "PNBUM0";

        /// <summary>
        /// PNLRFG.
        /// </summary>
        public const string PNLRFG = "PNLRFG";

        /// <summary>
        /// PNHCOR.
        /// </summary>
        public const string PNHCOR = "PNHCOR";

        /// <summary>
        /// PNACOR.
        /// </summary>
        public const string PNACOR = "PNACOR";

        /// <summary>
        /// PNABBL.
        /// </summary>
        public const string PNABBL = "PNABBL";

        /// <summary>
        /// PNATWH.
        /// </summary>
        public const string PNATWH = "PNATWH";

        /// <summary>
        /// PNRPLT.
        /// </summary>
        public const string PNRPLT = "PNRPLT";

        /// <summary>
        /// PNBCAT.
        /// </summary>
        public const string PNBCAT = "PNBCAT";

        /// <summary>
        /// PNFCAT.
        /// </summary>
        public const string PNFCAT = "PNFCAT";

        /// <summary>
        /// PNRECD.
        /// </summary>
        public const string PNRECD = "PNRECD";

        /// <summary>
        /// PNURCD.
        /// </summary>
        public const string PNURCD = "PNURCD";

        /// <summary>
        /// PNURAT.
        /// </summary>
        public const string PNURAT = "PNURAT";

        /// <summary>
        /// PNURAB.
        /// </summary>
        public const string PNURAB = "PNURAB";

        /// <summary>
        /// PNURRF.
        /// </summary>
        public const string PNURRF = "PNURRF";

        /// <summary>
        /// PNURDT.
        /// </summary>
        public const string PNURDT = "PNURDT";

        /// <summary>
        /// PNUSER.
        /// </summary>
        public const string PNUSER = "PNUSER";

        /// <summary>
        /// PNPID.
        /// </summary>
        public const string PNPID = "PNPID";

        /// <summary>
        /// PNJOBN.
        /// </summary>
        public const string PNJOBN = "PNJOBN";

        /// <summary>
        /// PNUPMJ.
        /// </summary>
        public const string PNUPMJ = "PNUPMJ";

        /// <summary>
        /// PNTDAY.
        /// </summary>
        public const string PNTDAY = "PNTDAY";

        /// <summary>
        /// PNRTOB.
        /// </summary>
        public const string PNRTOB = "PNRTOB";
    }

    /// <inheritdoc />
    public override string TableName => "F41022";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PNMCU", "PNMCU", JdeDataType.String, 24, true, true),
        new JdeField("PNITM", "PNITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PNSTVL", "PNSTVL", JdeDataType.Numeric),
        new JdeField("PNBUM0", "PNBUM0", JdeDataType.String, 4),
        new JdeField("PNLRFG", "PNLRFG", JdeDataType.String, 2),
        new JdeField("PNHCOR", "PNHCOR", JdeDataType.String, 2),
        new JdeField("PNACOR", "PNACOR", JdeDataType.String, 2),
        new JdeField("PNABBL", "PNABBL", JdeDataType.String, 2),
        new JdeField("PNATWH", "PNATWH", JdeDataType.String, 2),
        new JdeField("PNRPLT", "PNRPLT", JdeDataType.String, 6),
        new JdeField("PNBCAT", "PNBCAT", JdeDataType.String, 6),
        new JdeField("PNFCAT", "PNFCAT", JdeDataType.String, 6),
        new JdeField("PNRECD", "PNRECD", JdeDataType.Numeric),
        new JdeField("PNURCD", "PNURCD", JdeDataType.String, 4),
        new JdeField("PNURAT", "PNURAT", JdeDataType.Numeric),
        new JdeField("PNURAB", "PNURAB", JdeDataType.Numeric),
        new JdeField("PNURRF", "PNURRF", JdeDataType.String, 30),
        new JdeField("PNURDT", "PNURDT", JdeDataType.Numeric),
        new JdeField("PNUSER", "PNUSER", JdeDataType.String, 20),
        new JdeField("PNPID", "PNPID", JdeDataType.String, 20),
        new JdeField("PNJOBN", "PNJOBN", JdeDataType.String, 20),
        new JdeField("PNUPMJ", "PNUPMJ", JdeDataType.Numeric),
        new JdeField("PNTDAY", "PNTDAY", JdeDataType.Numeric),
        new JdeField("PNRTOB", "PNRTOB", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41022_0", "Primary Key on PNMCU, PNITM", new[] { "PNMCU", "PNITM" }, isUnique: true, isPrimaryKey: true)
    };
}
