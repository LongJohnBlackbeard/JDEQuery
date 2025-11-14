using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48161 - .
/// </summary>
public class F48161 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KCKNLT.
        /// </summary>
        public const string KCKNLT = "KCKNLT";

        /// <summary>
        /// KCKBCO.
        /// </summary>
        public const string KCKBCO = "KCKBCO";

        /// <summary>
        /// KCLNGP.
        /// </summary>
        public const string KCLNGP = "KCLNGP";

        /// <summary>
        /// KCDS40.
        /// </summary>
        public const string KCDS40 = "KCDS40";

        /// <summary>
        /// KCURDAT01.
        /// </summary>
        public const string KCURDAT01 = "KCURDAT01";

        /// <summary>
        /// KCURDAT02.
        /// </summary>
        public const string KCURDAT02 = "KCURDAT02";

        /// <summary>
        /// KCUK01.
        /// </summary>
        public const string KCUK01 = "KCUK01";

        /// <summary>
        /// KCKBCC1.
        /// </summary>
        public const string KCKBCC1 = "KCKBCC1";

        /// <summary>
        /// KCKBCC2.
        /// </summary>
        public const string KCKBCC2 = "KCKBCC2";

        /// <summary>
        /// KCKBCC3.
        /// </summary>
        public const string KCKBCC3 = "KCKBCC3";

        /// <summary>
        /// KCKBCC4.
        /// </summary>
        public const string KCKBCC4 = "KCKBCC4";

        /// <summary>
        /// KCKBCC5.
        /// </summary>
        public const string KCKBCC5 = "KCKBCC5";

        /// <summary>
        /// KCURAB.
        /// </summary>
        public const string KCURAB = "KCURAB";

        /// <summary>
        /// KCURAT.
        /// </summary>
        public const string KCURAT = "KCURAT";

        /// <summary>
        /// KCURCD.
        /// </summary>
        public const string KCURCD = "KCURCD";

        /// <summary>
        /// KCURDT.
        /// </summary>
        public const string KCURDT = "KCURDT";

        /// <summary>
        /// KCURRF.
        /// </summary>
        public const string KCURRF = "KCURRF";

        /// <summary>
        /// KCCRTU.
        /// </summary>
        public const string KCCRTU = "KCCRTU";

        /// <summary>
        /// KCUSER.
        /// </summary>
        public const string KCUSER = "KCUSER";

        /// <summary>
        /// KCPID.
        /// </summary>
        public const string KCPID = "KCPID";

        /// <summary>
        /// KCJOBN.
        /// </summary>
        public const string KCJOBN = "KCJOBN";

        /// <summary>
        /// KCUPMJ.
        /// </summary>
        public const string KCUPMJ = "KCUPMJ";

        /// <summary>
        /// KCUPMT.
        /// </summary>
        public const string KCUPMT = "KCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F48161";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KCKNLT", "KCKNLT", JdeDataType.String, 2, true, true),
        new JdeField("KCKBCO", "KCKBCO", JdeDataType.String, 30, true, true),
        new JdeField("KCLNGP", "KCLNGP", JdeDataType.String, 4, true, true),
        new JdeField("KCDS40", "KCDS40", JdeDataType.String, 80),
        new JdeField("KCURDAT01", "KCURDAT01", JdeDataType.Numeric),
        new JdeField("KCURDAT02", "KCURDAT02", JdeDataType.Numeric),
        new JdeField("KCUK01", "KCUK01", JdeDataType.Numeric),
        new JdeField("KCKBCC1", "KCKBCC1", JdeDataType.String, 20),
        new JdeField("KCKBCC2", "KCKBCC2", JdeDataType.String, 20),
        new JdeField("KCKBCC3", "KCKBCC3", JdeDataType.String, 20),
        new JdeField("KCKBCC4", "KCKBCC4", JdeDataType.String, 20),
        new JdeField("KCKBCC5", "KCKBCC5", JdeDataType.String, 20),
        new JdeField("KCURAB", "KCURAB", JdeDataType.Numeric),
        new JdeField("KCURAT", "KCURAT", JdeDataType.Numeric),
        new JdeField("KCURCD", "KCURCD", JdeDataType.String, 4),
        new JdeField("KCURDT", "KCURDT", JdeDataType.Numeric),
        new JdeField("KCURRF", "KCURRF", JdeDataType.String, 30),
        new JdeField("KCCRTU", "KCCRTU", JdeDataType.String, 20),
        new JdeField("KCUSER", "KCUSER", JdeDataType.String, 20),
        new JdeField("KCPID", "KCPID", JdeDataType.String, 20),
        new JdeField("KCJOBN", "KCJOBN", JdeDataType.String, 20),
        new JdeField("KCUPMJ", "KCUPMJ", JdeDataType.Numeric),
        new JdeField("KCUPMT", "KCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48161_0", "Primary Key on KCKNLT, KCKBCO, KCLNGP", new[] { "KCKNLT", "KCKBCO", "KCLNGP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48161_2", "Index on KCKBCO", new[] { "KCKBCO" }),
        new JdeIndex("F48161_3", "Index on SYS_NC00024$", new[] { "SYS_NC00024$" }),
        new JdeIndex("F48161_4", "Index on KCUK01, KCLNGP", new[] { "KCUK01", "KCLNGP" })
    };
}
