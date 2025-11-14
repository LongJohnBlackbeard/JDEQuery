using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F17111 - .
/// </summary>
public class F17111 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BCITYPE.
        /// </summary>
        public const string BCITYPE = "BCITYPE";

        /// <summary>
        /// BCAN8.
        /// </summary>
        public const string BCAN8 = "BCAN8";

        /// <summary>
        /// BCCTR.
        /// </summary>
        public const string BCCTR = "BCCTR";

        /// <summary>
        /// BCMMCU.
        /// </summary>
        public const string BCMMCU = "BCMMCU";

        /// <summary>
        /// BCITM.
        /// </summary>
        public const string BCITM = "BCITM";

        /// <summary>
        /// BCPRODM.
        /// </summary>
        public const string BCPRODM = "BCPRODM";

        /// <summary>
        /// BCPRODF.
        /// </summary>
        public const string BCPRODF = "BCPRODF";

        /// <summary>
        /// BCDCT.
        /// </summary>
        public const string BCDCT = "BCDCT";

        /// <summary>
        /// BCLNTY2.
        /// </summary>
        public const string BCLNTY2 = "BCLNTY2";

        /// <summary>
        /// BCCPGP.
        /// </summary>
        public const string BCCPGP = "BCCPGP";

        /// <summary>
        /// BCPRGR.
        /// </summary>
        public const string BCPRGR = "BCPRGR";

        /// <summary>
        /// BCLNID.
        /// </summary>
        public const string BCLNID = "BCLNID";

        /// <summary>
        /// BCSERP.
        /// </summary>
        public const string BCSERP = "BCSERP";

        /// <summary>
        /// BCWRLF.
        /// </summary>
        public const string BCWRLF = "BCWRLF";

        /// <summary>
        /// BCWRLFL.
        /// </summary>
        public const string BCWRLFL = "BCWRLFL";

        /// <summary>
        /// BCLNTY.
        /// </summary>
        public const string BCLNTY = "BCLNTY";

        /// <summary>
        /// BCMXMET1.
        /// </summary>
        public const string BCMXMET1 = "BCMXMET1";

        /// <summary>
        /// BCMXMET2.
        /// </summary>
        public const string BCMXMET2 = "BCMXMET2";

        /// <summary>
        /// BCMXMET3.
        /// </summary>
        public const string BCMXMET3 = "BCMXMET3";

        /// <summary>
        /// BCCRTU.
        /// </summary>
        public const string BCCRTU = "BCCRTU";

        /// <summary>
        /// BCUSER.
        /// </summary>
        public const string BCUSER = "BCUSER";

        /// <summary>
        /// BCPID.
        /// </summary>
        public const string BCPID = "BCPID";

        /// <summary>
        /// BCJOBN.
        /// </summary>
        public const string BCJOBN = "BCJOBN";

        /// <summary>
        /// BCUPMJ.
        /// </summary>
        public const string BCUPMJ = "BCUPMJ";

        /// <summary>
        /// BCUPMT.
        /// </summary>
        public const string BCUPMT = "BCUPMT";

        /// <summary>
        /// BCSHPCTR.
        /// </summary>
        public const string BCSHPCTR = "BCSHPCTR";
    }

    /// <inheritdoc />
    public override string TableName => "F17111";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BCITYPE", "BCITYPE", JdeDataType.String, 2, true, true),
        new JdeField("BCAN8", "BCAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("BCCTR", "BCCTR", JdeDataType.String, 6, true, true),
        new JdeField("BCMMCU", "BCMMCU", JdeDataType.String, 24, true, true),
        new JdeField("BCITM", "BCITM", JdeDataType.Numeric, null, true, true),
        new JdeField("BCPRODM", "BCPRODM", JdeDataType.String, 16, true, true),
        new JdeField("BCPRODF", "BCPRODF", JdeDataType.String, 16, true, true),
        new JdeField("BCDCT", "BCDCT", JdeDataType.String, 4, true, true),
        new JdeField("BCLNTY2", "BCLNTY2", JdeDataType.String, 4, true, true),
        new JdeField("BCCPGP", "BCCPGP", JdeDataType.String, 16, true, true),
        new JdeField("BCPRGR", "BCPRGR", JdeDataType.String, 16, true, true),
        new JdeField("BCLNID", "BCLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("BCSERP", "BCSERP", JdeDataType.String, 16),
        new JdeField("BCWRLF", "BCWRLF", JdeDataType.Numeric),
        new JdeField("BCWRLFL", "BCWRLFL", JdeDataType.Numeric),
        new JdeField("BCLNTY", "BCLNTY", JdeDataType.String, 4),
        new JdeField("BCMXMET1", "BCMXMET1", JdeDataType.Numeric),
        new JdeField("BCMXMET2", "BCMXMET2", JdeDataType.Numeric),
        new JdeField("BCMXMET3", "BCMXMET3", JdeDataType.Numeric),
        new JdeField("BCCRTU", "BCCRTU", JdeDataType.String, 20),
        new JdeField("BCUSER", "BCUSER", JdeDataType.String, 20),
        new JdeField("BCPID", "BCPID", JdeDataType.String, 20),
        new JdeField("BCJOBN", "BCJOBN", JdeDataType.String, 20),
        new JdeField("BCUPMJ", "BCUPMJ", JdeDataType.Numeric),
        new JdeField("BCUPMT", "BCUPMT", JdeDataType.Numeric),
        new JdeField("BCSHPCTR", "BCSHPCTR", JdeDataType.String, 6, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F17111_0", "Primary Key on BCITYPE, BCAN8, BCCTR, BCMMCU, BCITM, BCPRODM, BCPRODF, BCDCT, BCLNTY2, BCCPGP, BCSHPCTR, BCLNID, BCPRGR", new[] { "BCITYPE", "BCAN8", "BCCTR", "BCMMCU", "BCITM", "BCPRODM", "BCPRODF", "BCDCT", "BCLNTY2", "BCCPGP", "BCSHPCTR", "BCLNID", "BCPRGR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F17111_2", "Index on BCITYPE, BCAN8, BCCTR, BCMMCU, BCITM, BCPRODM, BCPRODF, BCSERP, BCWRLF, BCDCT, BCLNTY2, BCCPGP, BCSHPCTR, SYS_NC00027$, BCPRGR", new[] { "BCITYPE", "BCAN8", "BCCTR", "BCMMCU", "BCITM", "BCPRODM", "BCPRODF", "BCSERP", "BCWRLF", "BCDCT", "BCLNTY2", "BCCPGP", "BCSHPCTR", "SYS_NC00027$", "BCPRGR" }),
        new JdeIndex("F17111_3", "Index on BCITYPE, BCAN8, BCCTR, BCMMCU, BCITM, BCPRODM, BCPRODF, BCDCT, BCLNTY2, BCCPGP, BCSHPCTR, SYS_NC00027$, BCPRGR", new[] { "BCITYPE", "BCAN8", "BCCTR", "BCMMCU", "BCITM", "BCPRODM", "BCPRODF", "BCDCT", "BCLNTY2", "BCCPGP", "BCSHPCTR", "SYS_NC00027$", "BCPRGR" })
    };
}
