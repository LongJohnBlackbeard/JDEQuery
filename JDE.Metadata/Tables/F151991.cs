using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F151991 - .
/// </summary>
public class F151991 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NBICU.
        /// </summary>
        public const string NBICU = "NBICU";

        /// <summary>
        /// NBDOC.
        /// </summary>
        public const string NBDOC = "NBDOC";

        /// <summary>
        /// NBDCT.
        /// </summary>
        public const string NBDCT = "NBDCT";

        /// <summary>
        /// NBKCO.
        /// </summary>
        public const string NBKCO = "NBKCO";

        /// <summary>
        /// NBSFX.
        /// </summary>
        public const string NBSFX = "NBSFX";

        /// <summary>
        /// NBPO.
        /// </summary>
        public const string NBPO = "NBPO";

        /// <summary>
        /// NBGLC.
        /// </summary>
        public const string NBGLC = "NBGLC";

        /// <summary>
        /// NBMCU2.
        /// </summary>
        public const string NBMCU2 = "NBMCU2";

        /// <summary>
        /// NBUNIT.
        /// </summary>
        public const string NBUNIT = "NBUNIT";

        /// <summary>
        /// NBAG.
        /// </summary>
        public const string NBAG = "NBAG";

        /// <summary>
        /// NBDGJ.
        /// </summary>
        public const string NBDGJ = "NBDGJ";

        /// <summary>
        /// NBDIVJ.
        /// </summary>
        public const string NBDIVJ = "NBDIVJ";

        /// <summary>
        /// NBDDJ.
        /// </summary>
        public const string NBDDJ = "NBDDJ";

        /// <summary>
        /// NBDSVJ.
        /// </summary>
        public const string NBDSVJ = "NBDSVJ";

        /// <summary>
        /// NBDTE.
        /// </summary>
        public const string NBDTE = "NBDTE";

        /// <summary>
        /// NBACR.
        /// </summary>
        public const string NBACR = "NBACR";

        /// <summary>
        /// NBCRCD.
        /// </summary>
        public const string NBCRCD = "NBCRCD";

        /// <summary>
        /// NBCRR.
        /// </summary>
        public const string NBCRR = "NBCRR";

        /// <summary>
        /// NBCRRM.
        /// </summary>
        public const string NBCRRM = "NBCRRM";

        /// <summary>
        /// NBBCRC.
        /// </summary>
        public const string NBBCRC = "NBBCRC";
    }

    /// <inheritdoc />
    public override string TableName => "F151991";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NBICU", "NBICU", JdeDataType.Numeric, null, true, true),
        new JdeField("NBDOC", "NBDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("NBDCT", "NBDCT", JdeDataType.String, 4),
        new JdeField("NBKCO", "NBKCO", JdeDataType.String, 10, true, true),
        new JdeField("NBSFX", "NBSFX", JdeDataType.String, 6, true, true),
        new JdeField("NBPO", "NBPO", JdeDataType.String, 16),
        new JdeField("NBGLC", "NBGLC", JdeDataType.String, 8),
        new JdeField("NBMCU2", "NBMCU2", JdeDataType.String, 24),
        new JdeField("NBUNIT", "NBUNIT", JdeDataType.String, 16),
        new JdeField("NBAG", "NBAG", JdeDataType.Numeric),
        new JdeField("NBDGJ", "NBDGJ", JdeDataType.Numeric),
        new JdeField("NBDIVJ", "NBDIVJ", JdeDataType.Numeric),
        new JdeField("NBDDJ", "NBDDJ", JdeDataType.Numeric),
        new JdeField("NBDSVJ", "NBDSVJ", JdeDataType.Numeric),
        new JdeField("NBDTE", "NBDTE", JdeDataType.Numeric),
        new JdeField("NBACR", "NBACR", JdeDataType.Numeric),
        new JdeField("NBCRCD", "NBCRCD", JdeDataType.String, 6),
        new JdeField("NBCRR", "NBCRR", JdeDataType.Numeric),
        new JdeField("NBCRRM", "NBCRRM", JdeDataType.String, 2),
        new JdeField("NBBCRC", "NBBCRC", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F151991_0", "Primary Key on NBICU, NBDOC, NBKCO, NBSFX", new[] { "NBICU", "NBDOC", "NBKCO", "NBSFX" }, isUnique: true, isPrimaryKey: true)
    };
}
