using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1504 - .
/// </summary>
public class F1504 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NCDOCO.
        /// </summary>
        public const string NCDOCO = "NCDOCO";

        /// <summary>
        /// NCMCU.
        /// </summary>
        public const string NCMCU = "NCMCU";

        /// <summary>
        /// NCUNIT.
        /// </summary>
        public const string NCUNIT = "NCUNIT";

        /// <summary>
        /// NCLGNO.
        /// </summary>
        public const string NCLGNO = "NCLGNO";

        /// <summary>
        /// NCLNID.
        /// </summary>
        public const string NCLNID = "NCLNID";

        /// <summary>
        /// NCLDTA.
        /// </summary>
        public const string NCLDTA = "NCLDTA";

        /// <summary>
        /// NCFLOR.
        /// </summary>
        public const string NCFLOR = "NCFLOR";

        /// <summary>
        /// NCUSER.
        /// </summary>
        public const string NCUSER = "NCUSER";

        /// <summary>
        /// NCUPMJ.
        /// </summary>
        public const string NCUPMJ = "NCUPMJ";

        /// <summary>
        /// NCPID.
        /// </summary>
        public const string NCPID = "NCPID";

        /// <summary>
        /// NCJOBN.
        /// </summary>
        public const string NCJOBN = "NCJOBN";

        /// <summary>
        /// NCARGC.
        /// </summary>
        public const string NCARGC = "NCARGC";

        /// <summary>
        /// NCARGV.
        /// </summary>
        public const string NCARGV = "NCARGV";

        /// <summary>
        /// NCUPMT.
        /// </summary>
        public const string NCUPMT = "NCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1504";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NCDOCO", "NCDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NCMCU", "NCMCU", JdeDataType.String, 24, true, true),
        new JdeField("NCUNIT", "NCUNIT", JdeDataType.String, 16, true, true),
        new JdeField("NCLGNO", "NCLGNO", JdeDataType.Numeric, null, true, true),
        new JdeField("NCLNID", "NCLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("NCLDTA", "NCLDTA", JdeDataType.String, 120),
        new JdeField("NCFLOR", "NCFLOR", JdeDataType.String, 8, true, true),
        new JdeField("NCUSER", "NCUSER", JdeDataType.String, 20),
        new JdeField("NCUPMJ", "NCUPMJ", JdeDataType.Numeric),
        new JdeField("NCPID", "NCPID", JdeDataType.String, 20),
        new JdeField("NCJOBN", "NCJOBN", JdeDataType.String, 20),
        new JdeField("NCARGC", "NCARGC", JdeDataType.String, 8, true, true),
        new JdeField("NCARGV", "NCARGV", JdeDataType.String, 10, true, true),
        new JdeField("NCUPMT", "NCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1504_0", "Primary Key on NCDOCO, NCMCU, NCUNIT, NCFLOR, NCARGC, NCARGV, NCLGNO, NCLNID", new[] { "NCDOCO", "NCMCU", "NCUNIT", "NCFLOR", "NCARGC", "NCARGV", "NCLGNO", "NCLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
