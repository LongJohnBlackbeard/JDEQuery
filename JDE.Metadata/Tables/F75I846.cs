using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I846 - .
/// </summary>
public class F75I846 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GTUKID.
        /// </summary>
        public const string GTUKID = "GTUKID";

        /// <summary>
        /// GTKCOO.
        /// </summary>
        public const string GTKCOO = "GTKCOO";

        /// <summary>
        /// GTDCTO.
        /// </summary>
        public const string GTDCTO = "GTDCTO";

        /// <summary>
        /// GTDOCO.
        /// </summary>
        public const string GTDOCO = "GTDOCO";

        /// <summary>
        /// GTKCO.
        /// </summary>
        public const string GTKCO = "GTKCO";

        /// <summary>
        /// GTDCT.
        /// </summary>
        public const string GTDCT = "GTDCT";

        /// <summary>
        /// GTDOC.
        /// </summary>
        public const string GTDOC = "GTDOC";

        /// <summary>
        /// GTAPGM.
        /// </summary>
        public const string GTAPGM = "GTAPGM";

        /// <summary>
        /// GTI75TRCAT.
        /// </summary>
        public const string GTI75TRCAT = "GTI75TRCAT";

        /// <summary>
        /// GTI75IPOS.
        /// </summary>
        public const string GTI75IPOS = "GTI75IPOS";

        /// <summary>
        /// GTUSER.
        /// </summary>
        public const string GTUSER = "GTUSER";

        /// <summary>
        /// GTPID.
        /// </summary>
        public const string GTPID = "GTPID";

        /// <summary>
        /// GTJOBN.
        /// </summary>
        public const string GTJOBN = "GTJOBN";

        /// <summary>
        /// GTUPMJ.
        /// </summary>
        public const string GTUPMJ = "GTUPMJ";

        /// <summary>
        /// GTUPMT.
        /// </summary>
        public const string GTUPMT = "GTUPMT";

        /// <summary>
        /// GTYFUTDT1.
        /// </summary>
        public const string GTYFUTDT1 = "GTYFUTDT1";

        /// <summary>
        /// GTFUT6.
        /// </summary>
        public const string GTFUT6 = "GTFUT6";

        /// <summary>
        /// GTYT04.
        /// </summary>
        public const string GTYT04 = "GTYT04";

        /// <summary>
        /// GTYFLAG.
        /// </summary>
        public const string GTYFLAG = "GTYFLAG";
    }

    /// <inheritdoc />
    public override string TableName => "F75I846";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GTUKID", "GTUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("GTKCOO", "GTKCOO", JdeDataType.String, 10),
        new JdeField("GTDCTO", "GTDCTO", JdeDataType.String, 4),
        new JdeField("GTDOCO", "GTDOCO", JdeDataType.Numeric),
        new JdeField("GTKCO", "GTKCO", JdeDataType.String, 10),
        new JdeField("GTDCT", "GTDCT", JdeDataType.String, 4),
        new JdeField("GTDOC", "GTDOC", JdeDataType.Numeric),
        new JdeField("GTAPGM", "GTAPGM", JdeDataType.String, 20),
        new JdeField("GTI75TRCAT", "GTI75TRCAT", JdeDataType.String, 4),
        new JdeField("GTI75IPOS", "GTI75IPOS", JdeDataType.String, 4),
        new JdeField("GTUSER", "GTUSER", JdeDataType.String, 20),
        new JdeField("GTPID", "GTPID", JdeDataType.String, 20),
        new JdeField("GTJOBN", "GTJOBN", JdeDataType.String, 20),
        new JdeField("GTUPMJ", "GTUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("GTUPMT", "GTUPMT", JdeDataType.Numeric, null, true, true),
        new JdeField("GTYFUTDT1", "GTYFUTDT1", JdeDataType.Numeric),
        new JdeField("GTFUT6", "GTFUT6", JdeDataType.String, 60),
        new JdeField("GTYT04", "GTYT04", JdeDataType.String, 2),
        new JdeField("GTYFLAG", "GTYFLAG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I846_0", "Primary Key on GTUKID, GTUPMJ, GTUPMT", new[] { "GTUKID", "GTUPMJ", "GTUPMT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I846_2", "Index on GTKCOO, GTDCTO, GTDOCO", new[] { "GTKCOO", "GTDCTO", "GTDOCO" }),
        new JdeIndex("F75I846_3", "Index on GTKCO, GTDCT, GTDOC", new[] { "GTKCO", "GTDCT", "GTDOC" })
    };
}
