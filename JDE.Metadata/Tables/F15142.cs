using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15142 - .
/// </summary>
public class F15142 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NVARDEFID.
        /// </summary>
        public const string NVARDEFID = "NVARDEFID";

        /// <summary>
        /// NVDL01.
        /// </summary>
        public const string NVDL01 = "NVDL01";

        /// <summary>
        /// NVARTY.
        /// </summary>
        public const string NVARTY = "NVARTY";

        /// <summary>
        /// NVGLOADJ1.
        /// </summary>
        public const string NVGLOADJ1 = "NVGLOADJ1";

        /// <summary>
        /// NVGLOADJ2.
        /// </summary>
        public const string NVGLOADJ2 = "NVGLOADJ2";

        /// <summary>
        /// NVGLOADJ3.
        /// </summary>
        public const string NVGLOADJ3 = "NVGLOADJ3";

        /// <summary>
        /// NVGLOADJ4.
        /// </summary>
        public const string NVGLOADJ4 = "NVGLOADJ4";

        /// <summary>
        /// NVGLOADJ5.
        /// </summary>
        public const string NVGLOADJ5 = "NVGLOADJ5";

        /// <summary>
        /// NVGLAADJ1.
        /// </summary>
        public const string NVGLAADJ1 = "NVGLAADJ1";

        /// <summary>
        /// NVGLAADJ2.
        /// </summary>
        public const string NVGLAADJ2 = "NVGLAADJ2";

        /// <summary>
        /// NVGLAADJ3.
        /// </summary>
        public const string NVGLAADJ3 = "NVGLAADJ3";

        /// <summary>
        /// NVGLAADJ4.
        /// </summary>
        public const string NVGLAADJ4 = "NVGLAADJ4";

        /// <summary>
        /// NVGLAADJ5.
        /// </summary>
        public const string NVGLAADJ5 = "NVGLAADJ5";

        /// <summary>
        /// NVURCD.
        /// </summary>
        public const string NVURCD = "NVURCD";

        /// <summary>
        /// NVURDT.
        /// </summary>
        public const string NVURDT = "NVURDT";

        /// <summary>
        /// NVURAT.
        /// </summary>
        public const string NVURAT = "NVURAT";

        /// <summary>
        /// NVURAB.
        /// </summary>
        public const string NVURAB = "NVURAB";

        /// <summary>
        /// NVURRF.
        /// </summary>
        public const string NVURRF = "NVURRF";

        /// <summary>
        /// NVUSER.
        /// </summary>
        public const string NVUSER = "NVUSER";

        /// <summary>
        /// NVPID.
        /// </summary>
        public const string NVPID = "NVPID";

        /// <summary>
        /// NVMKEY.
        /// </summary>
        public const string NVMKEY = "NVMKEY";

        /// <summary>
        /// NVUPMJ.
        /// </summary>
        public const string NVUPMJ = "NVUPMJ";

        /// <summary>
        /// NVUPMT.
        /// </summary>
        public const string NVUPMT = "NVUPMT";

        /// <summary>
        /// NVTORG.
        /// </summary>
        public const string NVTORG = "NVTORG";

        /// <summary>
        /// NVENTJ.
        /// </summary>
        public const string NVENTJ = "NVENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F15142";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NVARDEFID", "NVARDEFID", JdeDataType.String, 20, true, true),
        new JdeField("NVDL01", "NVDL01", JdeDataType.String, 60),
        new JdeField("NVARTY", "NVARTY", JdeDataType.String, 6),
        new JdeField("NVGLOADJ1", "NVGLOADJ1", JdeDataType.String, 6),
        new JdeField("NVGLOADJ2", "NVGLOADJ2", JdeDataType.String, 6),
        new JdeField("NVGLOADJ3", "NVGLOADJ3", JdeDataType.String, 6),
        new JdeField("NVGLOADJ4", "NVGLOADJ4", JdeDataType.String, 6),
        new JdeField("NVGLOADJ5", "NVGLOADJ5", JdeDataType.String, 20),
        new JdeField("NVGLAADJ1", "NVGLAADJ1", JdeDataType.String, 6),
        new JdeField("NVGLAADJ2", "NVGLAADJ2", JdeDataType.String, 6),
        new JdeField("NVGLAADJ3", "NVGLAADJ3", JdeDataType.String, 6),
        new JdeField("NVGLAADJ4", "NVGLAADJ4", JdeDataType.String, 6),
        new JdeField("NVGLAADJ5", "NVGLAADJ5", JdeDataType.String, 6),
        new JdeField("NVURCD", "NVURCD", JdeDataType.String, 4),
        new JdeField("NVURDT", "NVURDT", JdeDataType.Numeric),
        new JdeField("NVURAT", "NVURAT", JdeDataType.Numeric),
        new JdeField("NVURAB", "NVURAB", JdeDataType.Numeric),
        new JdeField("NVURRF", "NVURRF", JdeDataType.String, 30),
        new JdeField("NVUSER", "NVUSER", JdeDataType.String, 20),
        new JdeField("NVPID", "NVPID", JdeDataType.String, 20),
        new JdeField("NVMKEY", "NVMKEY", JdeDataType.String, 30),
        new JdeField("NVUPMJ", "NVUPMJ", JdeDataType.Numeric),
        new JdeField("NVUPMT", "NVUPMT", JdeDataType.Numeric),
        new JdeField("NVTORG", "NVTORG", JdeDataType.String, 20),
        new JdeField("NVENTJ", "NVENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15142_0", "Primary Key on NVARDEFID", new[] { "NVARDEFID" }, isUnique: true, isPrimaryKey: true)
    };
}
