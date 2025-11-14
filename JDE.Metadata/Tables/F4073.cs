using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4073 - .
/// </summary>
public class F4073 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FGAST.
        /// </summary>
        public const string FGAST = "FGAST";

        /// <summary>
        /// FGATID.
        /// </summary>
        public const string FGATID = "FGATID";

        /// <summary>
        /// FGITMR.
        /// </summary>
        public const string FGITMR = "FGITMR";

        /// <summary>
        /// FGLITM.
        /// </summary>
        public const string FGLITM = "FGLITM";

        /// <summary>
        /// FGAITM.
        /// </summary>
        public const string FGAITM = "FGAITM";

        /// <summary>
        /// FGUORG.
        /// </summary>
        public const string FGUORG = "FGUORG";

        /// <summary>
        /// FGUOM.
        /// </summary>
        public const string FGUOM = "FGUOM";

        /// <summary>
        /// FGRPRI.
        /// </summary>
        public const string FGRPRI = "FGRPRI";

        /// <summary>
        /// FGUNCS.
        /// </summary>
        public const string FGUNCS = "FGUNCS";

        /// <summary>
        /// FGGLC.
        /// </summary>
        public const string FGGLC = "FGGLC";

        /// <summary>
        /// FGLNTY.
        /// </summary>
        public const string FGLNTY = "FGLNTY";

        /// <summary>
        /// FGFQTY.
        /// </summary>
        public const string FGFQTY = "FGFQTY";

        /// <summary>
        /// FGFGTY.
        /// </summary>
        public const string FGFGTY = "FGFGTY";

        /// <summary>
        /// FGFP01.
        /// </summary>
        public const string FGFP01 = "FGFP01";

        /// <summary>
        /// FGFP02.
        /// </summary>
        public const string FGFP02 = "FGFP02";

        /// <summary>
        /// FGFP03.
        /// </summary>
        public const string FGFP03 = "FGFP03";

        /// <summary>
        /// FGCATLG.
        /// </summary>
        public const string FGCATLG = "FGCATLG";

        /// <summary>
        /// FGAPRS.
        /// </summary>
        public const string FGAPRS = "FGAPRS";

        /// <summary>
        /// FGUSER.
        /// </summary>
        public const string FGUSER = "FGUSER";

        /// <summary>
        /// FGPID.
        /// </summary>
        public const string FGPID = "FGPID";

        /// <summary>
        /// FGJOBN.
        /// </summary>
        public const string FGJOBN = "FGJOBN";

        /// <summary>
        /// FGUPMJ.
        /// </summary>
        public const string FGUPMJ = "FGUPMJ";

        /// <summary>
        /// FGTDAY.
        /// </summary>
        public const string FGTDAY = "FGTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4073";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FGAST", "FGAST", JdeDataType.String, 16, true, true),
        new JdeField("FGATID", "FGATID", JdeDataType.Numeric, null, true, true),
        new JdeField("FGITMR", "FGITMR", JdeDataType.Numeric),
        new JdeField("FGLITM", "FGLITM", JdeDataType.String, 50, true, true),
        new JdeField("FGAITM", "FGAITM", JdeDataType.String, 50),
        new JdeField("FGUORG", "FGUORG", JdeDataType.Numeric),
        new JdeField("FGUOM", "FGUOM", JdeDataType.String, 4),
        new JdeField("FGRPRI", "FGRPRI", JdeDataType.Numeric),
        new JdeField("FGUNCS", "FGUNCS", JdeDataType.Numeric),
        new JdeField("FGGLC", "FGGLC", JdeDataType.String, 8),
        new JdeField("FGLNTY", "FGLNTY", JdeDataType.String, 4),
        new JdeField("FGFQTY", "FGFQTY", JdeDataType.Numeric),
        new JdeField("FGFGTY", "FGFGTY", JdeDataType.String, 2),
        new JdeField("FGFP01", "FGFP01", JdeDataType.String, 2),
        new JdeField("FGFP02", "FGFP02", JdeDataType.String, 2),
        new JdeField("FGFP03", "FGFP03", JdeDataType.String, 2),
        new JdeField("FGCATLG", "FGCATLG", JdeDataType.String, 20),
        new JdeField("FGAPRS", "FGAPRS", JdeDataType.String, 2),
        new JdeField("FGUSER", "FGUSER", JdeDataType.String, 20),
        new JdeField("FGPID", "FGPID", JdeDataType.String, 20),
        new JdeField("FGJOBN", "FGJOBN", JdeDataType.String, 20),
        new JdeField("FGUPMJ", "FGUPMJ", JdeDataType.Numeric),
        new JdeField("FGTDAY", "FGTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4073_0", "Primary Key on FGAST, FGATID, FGLITM", new[] { "FGAST", "FGATID", "FGLITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4073_2", "Index on FGAST, FGATID, FGLITM, SYS_NC00024$, SYS_NC00025$", new[] { "FGAST", "FGATID", "FGLITM", "SYS_NC00024$", "SYS_NC00025$" }),
        new JdeIndex("F4073_3", "Index on FGAST, FGATID, FGLITM, FGPID", new[] { "FGAST", "FGATID", "FGLITM", "FGPID" })
    };
}
