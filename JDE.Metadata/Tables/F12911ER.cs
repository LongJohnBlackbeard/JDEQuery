using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F12911ER - .
/// </summary>
public class F12911ER : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GLDCT.
        /// </summary>
        public const string GLDCT = "GLDCT";

        /// <summary>
        /// GLDOC.
        /// </summary>
        public const string GLDOC = "GLDOC";

        /// <summary>
        /// GLJELN.
        /// </summary>
        public const string GLJELN = "GLJELN";

        /// <summary>
        /// GLDGJ.
        /// </summary>
        public const string GLDGJ = "GLDGJ";

        /// <summary>
        /// GLANI.
        /// </summary>
        public const string GLANI = "GLANI";

        /// <summary>
        /// GLEXA.
        /// </summary>
        public const string GLEXA = "GLEXA";

        /// <summary>
        /// GLLT.
        /// </summary>
        public const string GLLT = "GLLT";

        /// <summary>
        /// GLCO.
        /// </summary>
        public const string GLCO = "GLCO";

        /// <summary>
        /// GLAA.
        /// </summary>
        public const string GLAA = "GLAA";

        /// <summary>
        /// GLU.
        /// </summary>
        public const string GLU = "GLU";

        /// <summary>
        /// GLASID.
        /// </summary>
        public const string GLASID = "GLASID";

        /// <summary>
        /// GLDL01.
        /// </summary>
        public const string GLDL01 = "GLDL01";

        /// <summary>
        /// GLDL02.
        /// </summary>
        public const string GLDL02 = "GLDL02";

        /// <summary>
        /// GLDL05.
        /// </summary>
        public const string GLDL05 = "GLDL05";

        /// <summary>
        /// GLCRCD.
        /// </summary>
        public const string GLCRCD = "GLCRCD";

        /// <summary>
        /// GLEXR.
        /// </summary>
        public const string GLEXR = "GLEXR";

        /// <summary>
        /// GLDTAI.
        /// </summary>
        public const string GLDTAI = "GLDTAI";

        /// <summary>
        /// GLDL06.
        /// </summary>
        public const string GLDL06 = "GLDL06";

        /// <summary>
        /// GLSBL.
        /// </summary>
        public const string GLSBL = "GLSBL";

        /// <summary>
        /// GLSBLT.
        /// </summary>
        public const string GLSBLT = "GLSBLT";
    }

    /// <inheritdoc />
    public override string TableName => "F12911ER";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GLDCT", "GLDCT", JdeDataType.String, 4, true, true),
        new JdeField("GLDOC", "GLDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("GLJELN", "GLJELN", JdeDataType.Numeric, null, true, true),
        new JdeField("GLDGJ", "GLDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("GLANI", "GLANI", JdeDataType.String, 58, true, true),
        new JdeField("GLEXA", "GLEXA", JdeDataType.String, 60),
        new JdeField("GLLT", "GLLT", JdeDataType.String, 4, true, true),
        new JdeField("GLCO", "GLCO", JdeDataType.String, 10, true, true),
        new JdeField("GLAA", "GLAA", JdeDataType.Numeric, null, true, true),
        new JdeField("GLU", "GLU", JdeDataType.Numeric),
        new JdeField("GLASID", "GLASID", JdeDataType.String, 50),
        new JdeField("GLDL01", "GLDL01", JdeDataType.String, 60),
        new JdeField("GLDL02", "GLDL02", JdeDataType.String, 60),
        new JdeField("GLDL05", "GLDL05", JdeDataType.String, 60),
        new JdeField("GLCRCD", "GLCRCD", JdeDataType.String, 6),
        new JdeField("GLEXR", "GLEXR", JdeDataType.String, 60),
        new JdeField("GLDTAI", "GLDTAI", JdeDataType.String, 20),
        new JdeField("GLDL06", "GLDL06", JdeDataType.String, 60),
        new JdeField("GLSBL", "GLSBL", JdeDataType.String, 16, true, true),
        new JdeField("GLSBLT", "GLSBLT", JdeDataType.String, 2, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F12911ER_0", "Primary Key on GLANI, GLCO, GLDCT, GLDOC, GLJELN, GLAA, GLLT, GLDGJ, GLSBL, GLSBLT", new[] { "GLANI", "GLCO", "GLDCT", "GLDOC", "GLJELN", "GLAA", "GLLT", "GLDGJ", "GLSBL", "GLSBLT" }, isUnique: true, isPrimaryKey: true)
    };
}
