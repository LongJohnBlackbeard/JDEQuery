using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41012 - .
/// </summary>
public class F41012 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VADNTB.
        /// </summary>
        public const string VADNTB = "VADNTB";

        /// <summary>
        /// VADSC1.
        /// </summary>
        public const string VADSC1 = "VADSC1";

        /// <summary>
        /// VADSMN.
        /// </summary>
        public const string VADSMN = "VADSMN";

        /// <summary>
        /// VADNMX.
        /// </summary>
        public const string VADNMX = "VADNMX";

        /// <summary>
        /// VADTBU.
        /// </summary>
        public const string VADTBU = "VADTBU";

        /// <summary>
        /// VABFEX.
        /// </summary>
        public const string VABFEX = "VABFEX";

        /// <summary>
        /// VABFTB.
        /// </summary>
        public const string VABFTB = "VABFTB";

        /// <summary>
        /// VAEXTB.
        /// </summary>
        public const string VAEXTB = "VAEXTB";

        /// <summary>
        /// VASTCN.
        /// </summary>
        public const string VASTCN = "VASTCN";

        /// <summary>
        /// VADSC2.
        /// </summary>
        public const string VADSC2 = "VADSC2";

        /// <summary>
        /// VATMMN.
        /// </summary>
        public const string VATMMN = "VATMMN";

        /// <summary>
        /// VATMMX.
        /// </summary>
        public const string VATMMX = "VATMMX";

        /// <summary>
        /// VATTBU.
        /// </summary>
        public const string VATTBU = "VATTBU";

        /// <summary>
        /// VABFEX2.
        /// </summary>
        public const string VABFEX2 = "VABFEX2";

        /// <summary>
        /// VABFTB2.
        /// </summary>
        public const string VABFTB2 = "VABFTB2";

        /// <summary>
        /// VAEXTB2.
        /// </summary>
        public const string VAEXTB2 = "VAEXTB2";

        /// <summary>
        /// VAVUOM.
        /// </summary>
        public const string VAVUOM = "VAVUOM";

        /// <summary>
        /// VAWUOM.
        /// </summary>
        public const string VAWUOM = "VAWUOM";

        /// <summary>
        /// VADTUM.
        /// </summary>
        public const string VADTUM = "VADTUM";

        /// <summary>
        /// VACTCD.
        /// </summary>
        public const string VACTCD = "VACTCD";

        /// <summary>
        /// VACTQT.
        /// </summary>
        public const string VACTQT = "VACTQT";

        /// <summary>
        /// VAFUAM.
        /// </summary>
        public const string VAFUAM = "VAFUAM";

        /// <summary>
        /// VACMDT.
        /// </summary>
        public const string VACMDT = "VACMDT";

        /// <summary>
        /// VACM01.
        /// </summary>
        public const string VACM01 = "VACM01";

        /// <summary>
        /// VAUSER.
        /// </summary>
        public const string VAUSER = "VAUSER";

        /// <summary>
        /// VAPID.
        /// </summary>
        public const string VAPID = "VAPID";

        /// <summary>
        /// VAUPMJ.
        /// </summary>
        public const string VAUPMJ = "VAUPMJ";

        /// <summary>
        /// VATDAY.
        /// </summary>
        public const string VATDAY = "VATDAY";

        /// <summary>
        /// VAJOBN.
        /// </summary>
        public const string VAJOBN = "VAJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F41012";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VADNTB", "VADNTB", JdeDataType.String, 8),
        new JdeField("VADSC1", "VADSC1", JdeDataType.String, 60),
        new JdeField("VADSMN", "VADSMN", JdeDataType.Numeric),
        new JdeField("VADNMX", "VADNMX", JdeDataType.Numeric),
        new JdeField("VADTBU", "VADTBU", JdeDataType.String, 2),
        new JdeField("VABFEX", "VABFEX", JdeDataType.String, 2),
        new JdeField("VABFTB", "VABFTB", JdeDataType.String, 120),
        new JdeField("VAEXTB", "VAEXTB", JdeDataType.String, 80),
        new JdeField("VASTCN", "VASTCN", JdeDataType.String, 8, true, true),
        new JdeField("VADSC2", "VADSC2", JdeDataType.String, 60),
        new JdeField("VATMMN", "VATMMN", JdeDataType.Numeric),
        new JdeField("VATMMX", "VATMMX", JdeDataType.Numeric),
        new JdeField("VATTBU", "VATTBU", JdeDataType.String, 2),
        new JdeField("VABFEX2", "VABFEX2", JdeDataType.String, 2),
        new JdeField("VABFTB2", "VABFTB2", JdeDataType.String, 120),
        new JdeField("VAEXTB2", "VAEXTB2", JdeDataType.String, 80),
        new JdeField("VAVUOM", "VAVUOM", JdeDataType.String, 4),
        new JdeField("VAWUOM", "VAWUOM", JdeDataType.String, 4),
        new JdeField("VADTUM", "VADTUM", JdeDataType.String, 2),
        new JdeField("VACTCD", "VACTCD", JdeDataType.String, 4),
        new JdeField("VACTQT", "VACTQT", JdeDataType.Numeric),
        new JdeField("VAFUAM", "VAFUAM", JdeDataType.Numeric),
        new JdeField("VACMDT", "VACMDT", JdeDataType.Numeric),
        new JdeField("VACM01", "VACM01", JdeDataType.String, 2),
        new JdeField("VAUSER", "VAUSER", JdeDataType.String, 20),
        new JdeField("VAPID", "VAPID", JdeDataType.String, 20),
        new JdeField("VAUPMJ", "VAUPMJ", JdeDataType.Numeric),
        new JdeField("VATDAY", "VATDAY", JdeDataType.Numeric),
        new JdeField("VAJOBN", "VAJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41012_0", "Primary Key on VASTCN", new[] { "VASTCN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F41012_2", "Index on VADNTB", new[] { "VADNTB" })
    };
}
