using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B10 - .
/// </summary>
public class F76B10 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ARCO.
        /// </summary>
        public const string ARCO = "ARCO";

        /// <summary>
        /// ARDGJ.
        /// </summary>
        public const string ARDGJ = "ARDGJ";

        /// <summary>
        /// ARMCU.
        /// </summary>
        public const string ARMCU = "ARMCU";

        /// <summary>
        /// AROBJ.
        /// </summary>
        public const string AROBJ = "AROBJ";

        /// <summary>
        /// ARSUB.
        /// </summary>
        public const string ARSUB = "ARSUB";

        /// <summary>
        /// ARSBL.
        /// </summary>
        public const string ARSBL = "ARSBL";

        /// <summary>
        /// ARAA.
        /// </summary>
        public const string ARAA = "ARAA";

        /// <summary>
        /// ARCRDB.
        /// </summary>
        public const string ARCRDB = "ARCRDB";

        /// <summary>
        /// ARMCUS.
        /// </summary>
        public const string ARMCUS = "ARMCUS";

        /// <summary>
        /// AROBJT.
        /// </summary>
        public const string AROBJT = "AROBJT";

        /// <summary>
        /// ARSUBT.
        /// </summary>
        public const string ARSUBT = "ARSUBT";

        /// <summary>
        /// ARSBLN.
        /// </summary>
        public const string ARSBLN = "ARSBLN";

        /// <summary>
        /// ARBRTPO.
        /// </summary>
        public const string ARBRTPO = "ARBRTPO";

        /// <summary>
        /// ARMCUF.
        /// </summary>
        public const string ARMCUF = "ARMCUF";

        /// <summary>
        /// ARMCUE.
        /// </summary>
        public const string ARMCUE = "ARMCUE";

        /// <summary>
        /// ARBRCHP.
        /// </summary>
        public const string ARBRCHP = "ARBRCHP";

        /// <summary>
        /// AREXA.
        /// </summary>
        public const string AREXA = "AREXA";

        /// <summary>
        /// AREXR.
        /// </summary>
        public const string AREXR = "AREXR";

        /// <summary>
        /// ARICU.
        /// </summary>
        public const string ARICU = "ARICU";

        /// <summary>
        /// ARPID.
        /// </summary>
        public const string ARPID = "ARPID";

        /// <summary>
        /// ARUSER.
        /// </summary>
        public const string ARUSER = "ARUSER";

        /// <summary>
        /// ARJOBN.
        /// </summary>
        public const string ARJOBN = "ARJOBN";

        /// <summary>
        /// ARUPMJ.
        /// </summary>
        public const string ARUPMJ = "ARUPMJ";

        /// <summary>
        /// ARUPMT.
        /// </summary>
        public const string ARUPMT = "ARUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B10";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ARCO", "ARCO", JdeDataType.String, 10, true, true),
        new JdeField("ARDGJ", "ARDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("ARMCU", "ARMCU", JdeDataType.String, 24, true, true),
        new JdeField("AROBJ", "AROBJ", JdeDataType.String, 12, true, true),
        new JdeField("ARSUB", "ARSUB", JdeDataType.String, 16, true, true),
        new JdeField("ARSBL", "ARSBL", JdeDataType.String, 16, true, true),
        new JdeField("ARAA", "ARAA", JdeDataType.Numeric),
        new JdeField("ARCRDB", "ARCRDB", JdeDataType.String, 2),
        new JdeField("ARMCUS", "ARMCUS", JdeDataType.String, 24),
        new JdeField("AROBJT", "AROBJT", JdeDataType.String, 12),
        new JdeField("ARSUBT", "ARSUBT", JdeDataType.String, 16),
        new JdeField("ARSBLN", "ARSBLN", JdeDataType.String, 16),
        new JdeField("ARBRTPO", "ARBRTPO", JdeDataType.String, 6),
        new JdeField("ARMCUF", "ARMCUF", JdeDataType.String, 24),
        new JdeField("ARMCUE", "ARMCUE", JdeDataType.String, 24),
        new JdeField("ARBRCHP", "ARBRCHP", JdeDataType.String, 8),
        new JdeField("AREXA", "AREXA", JdeDataType.String, 60),
        new JdeField("AREXR", "AREXR", JdeDataType.String, 60),
        new JdeField("ARICU", "ARICU", JdeDataType.Numeric),
        new JdeField("ARPID", "ARPID", JdeDataType.String, 20),
        new JdeField("ARUSER", "ARUSER", JdeDataType.String, 20),
        new JdeField("ARJOBN", "ARJOBN", JdeDataType.String, 20),
        new JdeField("ARUPMJ", "ARUPMJ", JdeDataType.Numeric),
        new JdeField("ARUPMT", "ARUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B10_0", "Primary Key on ARCO, ARDGJ, ARMCU, AROBJ, ARSUB, ARSBL", new[] { "ARCO", "ARDGJ", "ARMCU", "AROBJ", "ARSUB", "ARSBL" }, isUnique: true, isPrimaryKey: true)
    };
}
