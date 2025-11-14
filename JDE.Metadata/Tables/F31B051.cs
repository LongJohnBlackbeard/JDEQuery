using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B051 - .
/// </summary>
public class F31B051 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ECMCU.
        /// </summary>
        public const string ECMCU = "ECMCU";

        /// <summary>
        /// ECEQPID.
        /// </summary>
        public const string ECEQPID = "ECEQPID";

        /// <summary>
        /// ECITM.
        /// </summary>
        public const string ECITM = "ECITM";

        /// <summary>
        /// ECWECLN.
        /// </summary>
        public const string ECWECLN = "ECWECLN";

        /// <summary>
        /// ECUSGRATE.
        /// </summary>
        public const string ECUSGRATE = "ECUSGRATE";

        /// <summary>
        /// ECECQTY.
        /// </summary>
        public const string ECECQTY = "ECECQTY";

        /// <summary>
        /// ECUOM1.
        /// </summary>
        public const string ECUOM1 = "ECUOM1";

        /// <summary>
        /// ECURAB.
        /// </summary>
        public const string ECURAB = "ECURAB";

        /// <summary>
        /// ECURAT.
        /// </summary>
        public const string ECURAT = "ECURAT";

        /// <summary>
        /// ECURDT.
        /// </summary>
        public const string ECURDT = "ECURDT";

        /// <summary>
        /// ECURCD.
        /// </summary>
        public const string ECURCD = "ECURCD";

        /// <summary>
        /// ECURRF.
        /// </summary>
        public const string ECURRF = "ECURRF";

        /// <summary>
        /// ECUSER.
        /// </summary>
        public const string ECUSER = "ECUSER";

        /// <summary>
        /// ECUPMJ.
        /// </summary>
        public const string ECUPMJ = "ECUPMJ";

        /// <summary>
        /// ECUPMT.
        /// </summary>
        public const string ECUPMT = "ECUPMT";

        /// <summary>
        /// ECJOBN.
        /// </summary>
        public const string ECJOBN = "ECJOBN";

        /// <summary>
        /// ECMKEY.
        /// </summary>
        public const string ECMKEY = "ECMKEY";

        /// <summary>
        /// ECPID.
        /// </summary>
        public const string ECPID = "ECPID";
    }

    /// <inheritdoc />
    public override string TableName => "F31B051";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ECMCU", "ECMCU", JdeDataType.String, 24, true, true),
        new JdeField("ECEQPID", "ECEQPID", JdeDataType.Numeric, null, true, true),
        new JdeField("ECITM", "ECITM", JdeDataType.Numeric),
        new JdeField("ECWECLN", "ECWECLN", JdeDataType.Numeric, null, true, true),
        new JdeField("ECUSGRATE", "ECUSGRATE", JdeDataType.String, 30),
        new JdeField("ECECQTY", "ECECQTY", JdeDataType.Numeric),
        new JdeField("ECUOM1", "ECUOM1", JdeDataType.String, 4),
        new JdeField("ECURAB", "ECURAB", JdeDataType.Numeric),
        new JdeField("ECURAT", "ECURAT", JdeDataType.Numeric),
        new JdeField("ECURDT", "ECURDT", JdeDataType.Numeric),
        new JdeField("ECURCD", "ECURCD", JdeDataType.String, 4),
        new JdeField("ECURRF", "ECURRF", JdeDataType.String, 30),
        new JdeField("ECUSER", "ECUSER", JdeDataType.String, 20),
        new JdeField("ECUPMJ", "ECUPMJ", JdeDataType.Numeric),
        new JdeField("ECUPMT", "ECUPMT", JdeDataType.Numeric),
        new JdeField("ECJOBN", "ECJOBN", JdeDataType.String, 20),
        new JdeField("ECMKEY", "ECMKEY", JdeDataType.String, 30),
        new JdeField("ECPID", "ECPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B051_0", "Primary Key on ECMCU, ECEQPID, ECWECLN", new[] { "ECMCU", "ECEQPID", "ECWECLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B051_5", "Index on ECMCU, ECEQPID, ECITM, ECWECLN", new[] { "ECMCU", "ECEQPID", "ECITM", "ECWECLN" }),
        new JdeIndex("F31B051_6", "Index on ECMCU, ECEQPID, ECITM", new[] { "ECMCU", "ECEQPID", "ECITM" })
    };
}
