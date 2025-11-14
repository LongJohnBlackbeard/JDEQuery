using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B27 - .
/// </summary>
public class F03B27 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RMPLY.
        /// </summary>
        public const string RMPLY = "RMPLY";

        /// <summary>
        /// RMLNID.
        /// </summary>
        public const string RMLNID = "RMLNID";

        /// <summary>
        /// RMEFTB.
        /// </summary>
        public const string RMEFTB = "RMEFTB";

        /// <summary>
        /// RMEFTE.
        /// </summary>
        public const string RMEFTE = "RMEFTE";

        /// <summary>
        /// RMAGDB.
        /// </summary>
        public const string RMAGDB = "RMAGDB";

        /// <summary>
        /// RMAGDE.
        /// </summary>
        public const string RMAGDE = "RMAGDE";

        /// <summary>
        /// RMGPD.
        /// </summary>
        public const string RMGPD = "RMGPD";

        /// <summary>
        /// RMDELD.
        /// </summary>
        public const string RMDELD = "RMDELD";

        /// <summary>
        /// RMRETF.
        /// </summary>
        public const string RMRETF = "RMRETF";

        /// <summary>
        /// RMCMF.
        /// </summary>
        public const string RMCMF = "RMCMF";

        /// <summary>
        /// RMCOPN.
        /// </summary>
        public const string RMCOPN = "RMCOPN";

        /// <summary>
        /// RMCPAD.
        /// </summary>
        public const string RMCPAD = "RMCPAD";

        /// <summary>
        /// RMNTCM.
        /// </summary>
        public const string RMNTCM = "RMNTCM";

        /// <summary>
        /// RMCMAR.
        /// </summary>
        public const string RMCMAR = "RMCMAR";

        /// <summary>
        /// RMPFAM.
        /// </summary>
        public const string RMPFAM = "RMPFAM";

        /// <summary>
        /// RMPFFC.
        /// </summary>
        public const string RMPFFC = "RMPFFC";

        /// <summary>
        /// RMCRCD.
        /// </summary>
        public const string RMCRCD = "RMCRCD";

        /// <summary>
        /// RMANPR.
        /// </summary>
        public const string RMANPR = "RMANPR";

        /// <summary>
        /// RMAIPR.
        /// </summary>
        public const string RMAIPR = "RMAIPR";

        /// <summary>
        /// RMUSER.
        /// </summary>
        public const string RMUSER = "RMUSER";

        /// <summary>
        /// RMJOBN.
        /// </summary>
        public const string RMJOBN = "RMJOBN";

        /// <summary>
        /// RMPID.
        /// </summary>
        public const string RMPID = "RMPID";

        /// <summary>
        /// RMUPMT.
        /// </summary>
        public const string RMUPMT = "RMUPMT";

        /// <summary>
        /// RMUPMJ.
        /// </summary>
        public const string RMUPMJ = "RMUPMJ";

        /// <summary>
        /// RMFFR.
        /// </summary>
        public const string RMFFR = "RMFFR";
    }

    /// <inheritdoc />
    public override string TableName => "F03B27";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RMPLY", "RMPLY", JdeDataType.Numeric, null, true, true),
        new JdeField("RMLNID", "RMLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("RMEFTB", "RMEFTB", JdeDataType.Numeric),
        new JdeField("RMEFTE", "RMEFTE", JdeDataType.Numeric),
        new JdeField("RMAGDB", "RMAGDB", JdeDataType.Numeric),
        new JdeField("RMAGDE", "RMAGDE", JdeDataType.Numeric),
        new JdeField("RMGPD", "RMGPD", JdeDataType.Numeric),
        new JdeField("RMDELD", "RMDELD", JdeDataType.Numeric),
        new JdeField("RMRETF", "RMRETF", JdeDataType.String, 2),
        new JdeField("RMCMF", "RMCMF", JdeDataType.String, 2),
        new JdeField("RMCOPN", "RMCOPN", JdeDataType.String, 2),
        new JdeField("RMCPAD", "RMCPAD", JdeDataType.String, 2),
        new JdeField("RMNTCM", "RMNTCM", JdeDataType.String, 2),
        new JdeField("RMCMAR", "RMCMAR", JdeDataType.String, 2),
        new JdeField("RMPFAM", "RMPFAM", JdeDataType.Numeric),
        new JdeField("RMPFFC", "RMPFFC", JdeDataType.String, 2),
        new JdeField("RMCRCD", "RMCRCD", JdeDataType.String, 6),
        new JdeField("RMANPR", "RMANPR", JdeDataType.Numeric),
        new JdeField("RMAIPR", "RMAIPR", JdeDataType.String, 2),
        new JdeField("RMUSER", "RMUSER", JdeDataType.String, 20),
        new JdeField("RMJOBN", "RMJOBN", JdeDataType.String, 20),
        new JdeField("RMPID", "RMPID", JdeDataType.String, 20),
        new JdeField("RMUPMT", "RMUPMT", JdeDataType.Numeric),
        new JdeField("RMUPMJ", "RMUPMJ", JdeDataType.Numeric),
        new JdeField("RMFFR", "RMFFR", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B27_0", "Primary Key on RMPLY, RMLNID", new[] { "RMPLY", "RMLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
