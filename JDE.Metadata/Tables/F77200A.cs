using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F77200A - .
/// </summary>
public class F77200A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J5YEID.
        /// </summary>
        public const string J5YEID = "J5YEID";

        /// <summary>
        /// J5TAXYR.
        /// </summary>
        public const string J5TAXYR = "J5TAXYR";

        /// <summary>
        /// J5AN8.
        /// </summary>
        public const string J5AN8 = "J5AN8";

        /// <summary>
        /// J5FORMSID.
        /// </summary>
        public const string J5FORMSID = "J5FORMSID";

        /// <summary>
        /// J5CO.
        /// </summary>
        public const string J5CO = "J5CO";

        /// <summary>
        /// J5AMNDT.
        /// </summary>
        public const string J5AMNDT = "J5AMNDT";

        /// <summary>
        /// J5TARA.
        /// </summary>
        public const string J5TARA = "J5TARA";

        /// <summary>
        /// J5TAXX.
        /// </summary>
        public const string J5TAXX = "J5TAXX";

        /// <summary>
        /// J5REL1S.
        /// </summary>
        public const string J5REL1S = "J5REL1S";

        /// <summary>
        /// J5MBR1.
        /// </summary>
        public const string J5MBR1 = "J5MBR1";

        /// <summary>
        /// J5EV01.
        /// </summary>
        public const string J5EV01 = "J5EV01";

        /// <summary>
        /// J5EV02.
        /// </summary>
        public const string J5EV02 = "J5EV02";

        /// <summary>
        /// J5EV03.
        /// </summary>
        public const string J5EV03 = "J5EV03";

        /// <summary>
        /// J5MATH01.
        /// </summary>
        public const string J5MATH01 = "J5MATH01";

        /// <summary>
        /// J5MATH02.
        /// </summary>
        public const string J5MATH02 = "J5MATH02";

        /// <summary>
        /// J5MATH03.
        /// </summary>
        public const string J5MATH03 = "J5MATH03";

        /// <summary>
        /// J5W2P1.
        /// </summary>
        public const string J5W2P1 = "J5W2P1";

        /// <summary>
        /// J5UPMJ.
        /// </summary>
        public const string J5UPMJ = "J5UPMJ";

        /// <summary>
        /// J5UPMT.
        /// </summary>
        public const string J5UPMT = "J5UPMT";

        /// <summary>
        /// J5PID.
        /// </summary>
        public const string J5PID = "J5PID";

        /// <summary>
        /// J5JOBN.
        /// </summary>
        public const string J5JOBN = "J5JOBN";

        /// <summary>
        /// J5USER.
        /// </summary>
        public const string J5USER = "J5USER";
    }

    /// <inheritdoc />
    public override string TableName => "F77200A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J5YEID", "J5YEID", JdeDataType.String, 20, true, true),
        new JdeField("J5TAXYR", "J5TAXYR", JdeDataType.Numeric, null, true, true),
        new JdeField("J5AN8", "J5AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("J5FORMSID", "J5FORMSID", JdeDataType.Numeric, null, true, true),
        new JdeField("J5CO", "J5CO", JdeDataType.String, 10, true, true),
        new JdeField("J5AMNDT", "J5AMNDT", JdeDataType.String, 2, true, true),
        new JdeField("J5TARA", "J5TARA", JdeDataType.String, 20, true, true),
        new JdeField("J5TAXX", "J5TAXX", JdeDataType.String, 40, true, true),
        new JdeField("J5REL1S", "J5REL1S", JdeDataType.String, 2),
        new JdeField("J5MBR1", "J5MBR1", JdeDataType.String, 2),
        new JdeField("J5EV01", "J5EV01", JdeDataType.String, 2),
        new JdeField("J5EV02", "J5EV02", JdeDataType.String, 2),
        new JdeField("J5EV03", "J5EV03", JdeDataType.String, 2),
        new JdeField("J5MATH01", "J5MATH01", JdeDataType.Numeric),
        new JdeField("J5MATH02", "J5MATH02", JdeDataType.Numeric),
        new JdeField("J5MATH03", "J5MATH03", JdeDataType.Numeric),
        new JdeField("J5W2P1", "J5W2P1", JdeDataType.Numeric),
        new JdeField("J5UPMJ", "J5UPMJ", JdeDataType.Numeric),
        new JdeField("J5UPMT", "J5UPMT", JdeDataType.Numeric),
        new JdeField("J5PID", "J5PID", JdeDataType.String, 20),
        new JdeField("J5JOBN", "J5JOBN", JdeDataType.String, 20),
        new JdeField("J5USER", "J5USER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F77200A_0", "Primary Key on J5YEID, J5TAXYR, J5AN8, J5FORMSID, J5CO, J5AMNDT, J5TAXX, J5TARA", new[] { "J5YEID", "J5TAXYR", "J5AN8", "J5FORMSID", "J5CO", "J5AMNDT", "J5TAXX", "J5TARA" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F77200A_2", "Index on J5YEID, J5TAXYR, J5FORMSID", new[] { "J5YEID", "J5TAXYR", "J5FORMSID" })
    };
}
