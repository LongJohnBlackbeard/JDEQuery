using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F95155 - .
/// </summary>
public class F95155 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ILISLOGKEY.
        /// </summary>
        public const string ILISLOGKEY = "ILISLOGKEY";

        /// <summary>
        /// ILOBNM.
        /// </summary>
        public const string ILOBNM = "ILOBNM";

        /// <summary>
        /// ILDATP.
        /// </summary>
        public const string ILDATP = "ILDATP";

        /// <summary>
        /// ILINID.
        /// </summary>
        public const string ILINID = "ILINID";

        /// <summary>
        /// ILISLOGDSC.
        /// </summary>
        public const string ILISLOGDSC = "ILISLOGDSC";

        /// <summary>
        /// ILDATS.
        /// </summary>
        public const string ILDATS = "ILDATS";

        /// <summary>
        /// ILFUTUSE01.
        /// </summary>
        public const string ILFUTUSE01 = "ILFUTUSE01";

        /// <summary>
        /// ILFUT1.
        /// </summary>
        public const string ILFUT1 = "ILFUT1";

        /// <summary>
        /// ILFUT3.
        /// </summary>
        public const string ILFUT3 = "ILFUT3";

        /// <summary>
        /// ILPID.
        /// </summary>
        public const string ILPID = "ILPID";

        /// <summary>
        /// ILUSER.
        /// </summary>
        public const string ILUSER = "ILUSER";

        /// <summary>
        /// ILMKEY.
        /// </summary>
        public const string ILMKEY = "ILMKEY";

        /// <summary>
        /// ILUPMJ.
        /// </summary>
        public const string ILUPMJ = "ILUPMJ";

        /// <summary>
        /// ILUPMT.
        /// </summary>
        public const string ILUPMT = "ILUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F95155";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ILISLOGKEY", "ILISLOGKEY", JdeDataType.String, 72, true, true),
        new JdeField("ILOBNM", "ILOBNM", JdeDataType.String, 20),
        new JdeField("ILDATP", "ILDATP", JdeDataType.String, 60),
        new JdeField("ILINID", "ILINID", JdeDataType.Numeric),
        new JdeField("ILISLOGDSC", "ILISLOGDSC", JdeDataType.String, 400),
        new JdeField("ILDATS", "ILDATS", JdeDataType.String, 60),
        new JdeField("ILFUTUSE01", "ILFUTUSE01", JdeDataType.String, 2),
        new JdeField("ILFUT1", "ILFUT1", JdeDataType.Numeric),
        new JdeField("ILFUT3", "ILFUT3", JdeDataType.String, 60),
        new JdeField("ILPID", "ILPID", JdeDataType.String, 20),
        new JdeField("ILUSER", "ILUSER", JdeDataType.String, 20),
        new JdeField("ILMKEY", "ILMKEY", JdeDataType.String, 30),
        new JdeField("ILUPMJ", "ILUPMJ", JdeDataType.Numeric),
        new JdeField("ILUPMT", "ILUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F95155_0", "Primary Key on ILISLOGKEY", new[] { "ILISLOGKEY" }, isUnique: true, isPrimaryKey: true)
    };
}
