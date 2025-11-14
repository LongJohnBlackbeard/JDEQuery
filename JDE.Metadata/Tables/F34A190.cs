using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34A190 - .
/// </summary>
public class F34A190 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RDTRT.
        /// </summary>
        public const string RDTRT = "RDTRT";

        /// <summary>
        /// RDKIT.
        /// </summary>
        public const string RDKIT = "RDKIT";

        /// <summary>
        /// RDMMCU.
        /// </summary>
        public const string RDMMCU = "RDMMCU";

        /// <summary>
        /// RDLINE.
        /// </summary>
        public const string RDLINE = "RDLINE";

        /// <summary>
        /// RDOPSQ.
        /// </summary>
        public const string RDOPSQ = "RDOPSQ";

        /// <summary>
        /// RDEFFF.
        /// </summary>
        public const string RDEFFF = "RDEFFF";

        /// <summary>
        /// RDBQTY.
        /// </summary>
        public const string RDBQTY = "RDBQTY";

        /// <summary>
        /// RDOPSC.
        /// </summary>
        public const string RDOPSC = "RDOPSC";

        /// <summary>
        /// RDMCU.
        /// </summary>
        public const string RDMCU = "RDMCU";

        /// <summary>
        /// RDRESCD.
        /// </summary>
        public const string RDRESCD = "RDRESCD";

        /// <summary>
        /// RDRSETID.
        /// </summary>
        public const string RDRSETID = "RDRSETID";

        /// <summary>
        /// RDRESPRE.
        /// </summary>
        public const string RDRESPRE = "RDRESPRE";

        /// <summary>
        /// RDURCD.
        /// </summary>
        public const string RDURCD = "RDURCD";

        /// <summary>
        /// RDURDT.
        /// </summary>
        public const string RDURDT = "RDURDT";

        /// <summary>
        /// RDURAT.
        /// </summary>
        public const string RDURAT = "RDURAT";

        /// <summary>
        /// RDURAB.
        /// </summary>
        public const string RDURAB = "RDURAB";

        /// <summary>
        /// RDURRF.
        /// </summary>
        public const string RDURRF = "RDURRF";

        /// <summary>
        /// RDUSER.
        /// </summary>
        public const string RDUSER = "RDUSER";

        /// <summary>
        /// RDMKEY.
        /// </summary>
        public const string RDMKEY = "RDMKEY";

        /// <summary>
        /// RDPID.
        /// </summary>
        public const string RDPID = "RDPID";

        /// <summary>
        /// RDUUPMJ.
        /// </summary>
        public const string RDUUPMJ = "RDUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F34A190";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RDTRT", "RDTRT", JdeDataType.String, 6, true, true),
        new JdeField("RDKIT", "RDKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("RDMMCU", "RDMMCU", JdeDataType.String, 24, true, true),
        new JdeField("RDLINE", "RDLINE", JdeDataType.String, 24, true, true),
        new JdeField("RDOPSQ", "RDOPSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("RDEFFF", "RDEFFF", JdeDataType.Numeric, null, true, true),
        new JdeField("RDBQTY", "RDBQTY", JdeDataType.Numeric, null, true, true),
        new JdeField("RDOPSC", "RDOPSC", JdeDataType.String, 4, true, true),
        new JdeField("RDMCU", "RDMCU", JdeDataType.String, 24, true, true),
        new JdeField("RDRESCD", "RDRESCD", JdeDataType.String, 24, true, true),
        new JdeField("RDRSETID", "RDRSETID", JdeDataType.String, 20),
        new JdeField("RDRESPRE", "RDRESPRE", JdeDataType.Numeric),
        new JdeField("RDURCD", "RDURCD", JdeDataType.String, 4),
        new JdeField("RDURDT", "RDURDT", JdeDataType.Numeric),
        new JdeField("RDURAT", "RDURAT", JdeDataType.Numeric),
        new JdeField("RDURAB", "RDURAB", JdeDataType.Numeric),
        new JdeField("RDURRF", "RDURRF", JdeDataType.String, 30),
        new JdeField("RDUSER", "RDUSER", JdeDataType.String, 20),
        new JdeField("RDMKEY", "RDMKEY", JdeDataType.String, 30),
        new JdeField("RDPID", "RDPID", JdeDataType.String, 20),
        new JdeField("RDUUPMJ", "RDUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34A190_0", "Primary Key on RDTRT, RDKIT, RDMMCU, RDLINE, RDOPSQ, RDEFFF, RDBQTY, RDOPSC, RDMCU, RDRESCD", new[] { "RDTRT", "RDKIT", "RDMMCU", "RDLINE", "RDOPSQ", "RDEFFF", "RDBQTY", "RDOPSC", "RDMCU", "RDRESCD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F34A190_2", "Index on RDTRT, RDKIT, RDMMCU, RDLINE, RDOPSQ, RDEFFF, RDBQTY, RDOPSC, RDMCU, RDRSETID", new[] { "RDTRT", "RDKIT", "RDMMCU", "RDLINE", "RDOPSQ", "RDEFFF", "RDBQTY", "RDOPSC", "RDMCU", "RDRSETID" })
    };
}
