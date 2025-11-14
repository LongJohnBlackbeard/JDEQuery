using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F95815 - .
/// </summary>
public class F95815 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ILTXTBSVW.
        /// </summary>
        public const string ILTXTBSVW = "ILTXTBSVW";

        /// <summary>
        /// ILTXTDAT.
        /// </summary>
        public const string ILTXTDAT = "ILTXTDAT";

        /// <summary>
        /// ILTXTLNGP.
        /// </summary>
        public const string ILTXTLNGP = "ILTXTLNGP";

        /// <summary>
        /// ILTXTLFU1.
        /// </summary>
        public const string ILTXTLFU1 = "ILTXTLFU1";

        /// <summary>
        /// ILTXTLFU2.
        /// </summary>
        public const string ILTXTLFU2 = "ILTXTLFU2";

        /// <summary>
        /// ILTXTLFU3.
        /// </summary>
        public const string ILTXTLFU3 = "ILTXTLFU3";

        /// <summary>
        /// ILTXTLFU4.
        /// </summary>
        public const string ILTXTLFU4 = "ILTXTLFU4";

        /// <summary>
        /// ILTXTLFU5.
        /// </summary>
        public const string ILTXTLFU5 = "ILTXTLFU5";

        /// <summary>
        /// ILTXTLFU6.
        /// </summary>
        public const string ILTXTLFU6 = "ILTXTLFU6";

        /// <summary>
        /// ILUSER.
        /// </summary>
        public const string ILUSER = "ILUSER";

        /// <summary>
        /// ILPID.
        /// </summary>
        public const string ILPID = "ILPID";

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
    public override string TableName => "F95815";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ILTXTBSVW", "ILTXTBSVW", JdeDataType.String, 20, true, true),
        new JdeField("ILTXTDAT", "ILTXTDAT", JdeDataType.String, 60, true, true),
        new JdeField("ILTXTLNGP", "ILTXTLNGP", JdeDataType.String, 4, true, true),
        new JdeField("ILTXTLFU1", "ILTXTLFU1", JdeDataType.String, 2),
        new JdeField("ILTXTLFU2", "ILTXTLFU2", JdeDataType.String, 2),
        new JdeField("ILTXTLFU3", "ILTXTLFU3", JdeDataType.Numeric),
        new JdeField("ILTXTLFU4", "ILTXTLFU4", JdeDataType.Numeric),
        new JdeField("ILTXTLFU5", "ILTXTLFU5", JdeDataType.String, 512),
        new JdeField("ILTXTLFU6", "ILTXTLFU6", JdeDataType.String, 512),
        new JdeField("ILUSER", "ILUSER", JdeDataType.String, 20),
        new JdeField("ILPID", "ILPID", JdeDataType.String, 20),
        new JdeField("ILMKEY", "ILMKEY", JdeDataType.String, 30),
        new JdeField("ILUPMJ", "ILUPMJ", JdeDataType.Numeric),
        new JdeField("ILUPMT", "ILUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F95815_0", "Primary Key on ILTXTBSVW, ILTXTDAT, ILTXTLNGP", new[] { "ILTXTBSVW", "ILTXTDAT", "ILTXTLNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
