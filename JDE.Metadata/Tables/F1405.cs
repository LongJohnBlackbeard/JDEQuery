using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1405 - .
/// </summary>
public class F1405 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BBMCU.
        /// </summary>
        public const string BBMCU = "BBMCU";

        /// <summary>
        /// BBRVNUM.
        /// </summary>
        public const string BBRVNUM = "BBRVNUM";

        /// <summary>
        /// BBGRWPC.
        /// </summary>
        public const string BBGRWPC = "BBGRWPC";

        /// <summary>
        /// BBBGCD01.
        /// </summary>
        public const string BBBGCD01 = "BBBGCD01";

        /// <summary>
        /// BBBGCD02.
        /// </summary>
        public const string BBBGCD02 = "BBBGCD02";

        /// <summary>
        /// BBBGCD03.
        /// </summary>
        public const string BBBGCD03 = "BBBGCD03";

        /// <summary>
        /// BBBGCD04.
        /// </summary>
        public const string BBBGCD04 = "BBBGCD04";

        /// <summary>
        /// BBBGCD05.
        /// </summary>
        public const string BBBGCD05 = "BBBGCD05";

        /// <summary>
        /// BBBGCD06.
        /// </summary>
        public const string BBBGCD06 = "BBBGCD06";

        /// <summary>
        /// BBBGCD07.
        /// </summary>
        public const string BBBGCD07 = "BBBGCD07";

        /// <summary>
        /// BBBGCD08.
        /// </summary>
        public const string BBBGCD08 = "BBBGCD08";

        /// <summary>
        /// BBBGCD09.
        /// </summary>
        public const string BBBGCD09 = "BBBGCD09";

        /// <summary>
        /// BBBGCD10.
        /// </summary>
        public const string BBBGCD10 = "BBBGCD10";

        /// <summary>
        /// BBUSER.
        /// </summary>
        public const string BBUSER = "BBUSER";

        /// <summary>
        /// BBPID.
        /// </summary>
        public const string BBPID = "BBPID";

        /// <summary>
        /// BBJOBN.
        /// </summary>
        public const string BBJOBN = "BBJOBN";

        /// <summary>
        /// BBUPMJ.
        /// </summary>
        public const string BBUPMJ = "BBUPMJ";

        /// <summary>
        /// BBUPMT.
        /// </summary>
        public const string BBUPMT = "BBUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1405";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BBMCU", "BBMCU", JdeDataType.String, 24, true, true),
        new JdeField("BBRVNUM", "BBRVNUM", JdeDataType.String, 20, true, true),
        new JdeField("BBGRWPC", "BBGRWPC", JdeDataType.String, 20),
        new JdeField("BBBGCD01", "BBBGCD01", JdeDataType.String, 20),
        new JdeField("BBBGCD02", "BBBGCD02", JdeDataType.String, 20),
        new JdeField("BBBGCD03", "BBBGCD03", JdeDataType.String, 20),
        new JdeField("BBBGCD04", "BBBGCD04", JdeDataType.String, 20),
        new JdeField("BBBGCD05", "BBBGCD05", JdeDataType.String, 20),
        new JdeField("BBBGCD06", "BBBGCD06", JdeDataType.String, 20),
        new JdeField("BBBGCD07", "BBBGCD07", JdeDataType.String, 20),
        new JdeField("BBBGCD08", "BBBGCD08", JdeDataType.String, 20),
        new JdeField("BBBGCD09", "BBBGCD09", JdeDataType.String, 20),
        new JdeField("BBBGCD10", "BBBGCD10", JdeDataType.String, 20),
        new JdeField("BBUSER", "BBUSER", JdeDataType.String, 20),
        new JdeField("BBPID", "BBPID", JdeDataType.String, 20),
        new JdeField("BBJOBN", "BBJOBN", JdeDataType.String, 20),
        new JdeField("BBUPMJ", "BBUPMJ", JdeDataType.Numeric),
        new JdeField("BBUPMT", "BBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1405_0", "Primary Key on BBMCU, BBRVNUM", new[] { "BBMCU", "BBRVNUM" }, isUnique: true, isPrimaryKey: true)
    };
}
