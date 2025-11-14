using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49160 - .
/// </summary>
public class F49160 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NNCO.
        /// </summary>
        public const string NNCO = "NNCO";

        /// <summary>
        /// NNEMCU.
        /// </summary>
        public const string NNEMCU = "NNEMCU";

        /// <summary>
        /// NNMCU.
        /// </summary>
        public const string NNMCU = "NNMCU";

        /// <summary>
        /// NNDCT.
        /// </summary>
        public const string NNDCT = "NNDCT";

        /// <summary>
        /// NNEFTJ.
        /// </summary>
        public const string NNEFTJ = "NNEFTJ";

        /// <summary>
        /// NNEXDJ.
        /// </summary>
        public const string NNEXDJ = "NNEXDJ";

        /// <summary>
        /// NNN001.
        /// </summary>
        public const string NNN001 = "NNN001";

        /// <summary>
        /// NNN002.
        /// </summary>
        public const string NNN002 = "NNN002";

        /// <summary>
        /// NNN003.
        /// </summary>
        public const string NNN003 = "NNN003";

        /// <summary>
        /// NNIMBY.
        /// </summary>
        public const string NNIMBY = "NNIMBY";

        /// <summary>
        /// NNIMBM.
        /// </summary>
        public const string NNIMBM = "NNIMBM";

        /// <summary>
        /// NNUSER.
        /// </summary>
        public const string NNUSER = "NNUSER";

        /// <summary>
        /// NNPID.
        /// </summary>
        public const string NNPID = "NNPID";

        /// <summary>
        /// NNJOBN.
        /// </summary>
        public const string NNJOBN = "NNJOBN";

        /// <summary>
        /// NNUPMJ.
        /// </summary>
        public const string NNUPMJ = "NNUPMJ";

        /// <summary>
        /// NNTDAY.
        /// </summary>
        public const string NNTDAY = "NNTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49160";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NNCO", "NNCO", JdeDataType.String, 10, true, true),
        new JdeField("NNEMCU", "NNEMCU", JdeDataType.String, 24, true, true),
        new JdeField("NNMCU", "NNMCU", JdeDataType.String, 24, true, true),
        new JdeField("NNDCT", "NNDCT", JdeDataType.String, 4, true, true),
        new JdeField("NNEFTJ", "NNEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("NNEXDJ", "NNEXDJ", JdeDataType.Numeric),
        new JdeField("NNN001", "NNN001", JdeDataType.Numeric),
        new JdeField("NNN002", "NNN002", JdeDataType.Numeric),
        new JdeField("NNN003", "NNN003", JdeDataType.Numeric),
        new JdeField("NNIMBY", "NNIMBY", JdeDataType.String, 2),
        new JdeField("NNIMBM", "NNIMBM", JdeDataType.String, 2),
        new JdeField("NNUSER", "NNUSER", JdeDataType.String, 20),
        new JdeField("NNPID", "NNPID", JdeDataType.String, 20),
        new JdeField("NNJOBN", "NNJOBN", JdeDataType.String, 20),
        new JdeField("NNUPMJ", "NNUPMJ", JdeDataType.Numeric),
        new JdeField("NNTDAY", "NNTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49160_0", "Primary Key on NNCO, NNEMCU, NNMCU, NNDCT, NNEFTJ", new[] { "NNCO", "NNEMCU", "NNMCU", "NNDCT", "NNEFTJ" }, isUnique: true, isPrimaryKey: true)
    };
}
