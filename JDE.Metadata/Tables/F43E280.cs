using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43E280 - .
/// </summary>
public class F43E280 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DTDELSL.
        /// </summary>
        public const string DTDELSL = "DTDELSL";

        /// <summary>
        /// DTDELID.
        /// </summary>
        public const string DTDELID = "DTDELID";

        /// <summary>
        /// DTDELFRMID.
        /// </summary>
        public const string DTDELFRMID = "DTDELFRMID";

        /// <summary>
        /// DTDELTOID.
        /// </summary>
        public const string DTDELTOID = "DTDELTOID";

        /// <summary>
        /// DTDELAPP.
        /// </summary>
        public const string DTDELAPP = "DTDELAPP";

        /// <summary>
        /// DTDELEFFDT.
        /// </summary>
        public const string DTDELEFFDT = "DTDELEFFDT";

        /// <summary>
        /// DTDELEXPDT.
        /// </summary>
        public const string DTDELEXPDT = "DTDELEXPDT";

        /// <summary>
        /// DTDELFLG.
        /// </summary>
        public const string DTDELFLG = "DTDELFLG";

        /// <summary>
        /// DTUSER.
        /// </summary>
        public const string DTUSER = "DTUSER";

        /// <summary>
        /// DTPID.
        /// </summary>
        public const string DTPID = "DTPID";

        /// <summary>
        /// DTJOBN.
        /// </summary>
        public const string DTJOBN = "DTJOBN";

        /// <summary>
        /// DTUPMJ.
        /// </summary>
        public const string DTUPMJ = "DTUPMJ";

        /// <summary>
        /// DTUPMT.
        /// </summary>
        public const string DTUPMT = "DTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F43E280";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DTDELSL", "DTDELSL", JdeDataType.Numeric, null, true, true),
        new JdeField("DTDELID", "DTDELID", JdeDataType.String, 20),
        new JdeField("DTDELFRMID", "DTDELFRMID", JdeDataType.Numeric),
        new JdeField("DTDELTOID", "DTDELTOID", JdeDataType.Numeric),
        new JdeField("DTDELAPP", "DTDELAPP", JdeDataType.String, 20),
        new JdeField("DTDELEFFDT", "DTDELEFFDT", JdeDataType.Numeric),
        new JdeField("DTDELEXPDT", "DTDELEXPDT", JdeDataType.Numeric),
        new JdeField("DTDELFLG", "DTDELFLG", JdeDataType.String, 2),
        new JdeField("DTUSER", "DTUSER", JdeDataType.String, 20),
        new JdeField("DTPID", "DTPID", JdeDataType.String, 20),
        new JdeField("DTJOBN", "DTJOBN", JdeDataType.String, 20),
        new JdeField("DTUPMJ", "DTUPMJ", JdeDataType.Numeric),
        new JdeField("DTUPMT", "DTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43E280_0", "Primary Key on DTDELSL", new[] { "DTDELSL" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43E280_2", "Index on DTDELFRMID, DTDELTOID, DTDELAPP, DTDELFLG", new[] { "DTDELFRMID", "DTDELTOID", "DTDELAPP", "DTDELFLG" })
    };
}
