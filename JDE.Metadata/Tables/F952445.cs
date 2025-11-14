using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F952445 - .
/// </summary>
public class F952445 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ESWOBNM.
        /// </summary>
        public const string ESWOBNM = "ESWOBNM";

        /// <summary>
        /// ESWOUSER.
        /// </summary>
        public const string ESWOUSER = "ESWOUSER";

        /// <summary>
        /// ESWOOBNMS.
        /// </summary>
        public const string ESWOOBNMS = "ESWOOBNMS";

        /// <summary>
        /// ESWOOBNML.
        /// </summary>
        public const string ESWOOBNML = "ESWOOBNML";

        /// <summary>
        /// ESSY.
        /// </summary>
        public const string ESSY = "ESSY";

        /// <summary>
        /// ESOMRBLOB.
        /// </summary>
        public const string ESOMRBLOB = "ESOMRBLOB";

        /// <summary>
        /// ESUSER.
        /// </summary>
        public const string ESUSER = "ESUSER";

        /// <summary>
        /// ESWOUTIME.
        /// </summary>
        public const string ESWOUTIME = "ESWOUTIME";

        /// <summary>
        /// ESPID.
        /// </summary>
        public const string ESPID = "ESPID";

        /// <summary>
        /// ESMKEY.
        /// </summary>
        public const string ESMKEY = "ESMKEY";

        /// <summary>
        /// ESWOFU1.
        /// </summary>
        public const string ESWOFU1 = "ESWOFU1";

        /// <summary>
        /// ESWOFU2.
        /// </summary>
        public const string ESWOFU2 = "ESWOFU2";

        /// <summary>
        /// ESWOFU3.
        /// </summary>
        public const string ESWOFU3 = "ESWOFU3";

        /// <summary>
        /// ESWOFU4.
        /// </summary>
        public const string ESWOFU4 = "ESWOFU4";

        /// <summary>
        /// ESWOFU5.
        /// </summary>
        public const string ESWOFU5 = "ESWOFU5";

        /// <summary>
        /// ESWOFU6.
        /// </summary>
        public const string ESWOFU6 = "ESWOFU6";

        /// <summary>
        /// ESWOFU7.
        /// </summary>
        public const string ESWOFU7 = "ESWOFU7";

        /// <summary>
        /// ESWOFU8.
        /// </summary>
        public const string ESWOFU8 = "ESWOFU8";

        /// <summary>
        /// ESWOFU9.
        /// </summary>
        public const string ESWOFU9 = "ESWOFU9";

        /// <summary>
        /// ESWOFU10.
        /// </summary>
        public const string ESWOFU10 = "ESWOFU10";
    }

    /// <inheritdoc />
    public override string TableName => "F952445";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ESWOBNM", "ESWOBNM", JdeDataType.String, 60, true, true),
        new JdeField("ESWOUSER", "ESWOUSER", JdeDataType.String, 60, true, true),
        new JdeField("ESWOOBNMS", "ESWOOBNMS", JdeDataType.String, 100),
        new JdeField("ESWOOBNML", "ESWOOBNML", JdeDataType.String, 400),
        new JdeField("ESSY", "ESSY", JdeDataType.String, 8),
        new JdeField("ESOMRBLOB", "ESOMRBLOB", JdeDataType.String),
        new JdeField("ESUSER", "ESUSER", JdeDataType.String, 20),
        new JdeField("ESWOUTIME", "ESWOUTIME", JdeDataType.Date),
        new JdeField("ESPID", "ESPID", JdeDataType.String, 20),
        new JdeField("ESMKEY", "ESMKEY", JdeDataType.String, 30),
        new JdeField("ESWOFU1", "ESWOFU1", JdeDataType.String, 2),
        new JdeField("ESWOFU2", "ESWOFU2", JdeDataType.String, 2),
        new JdeField("ESWOFU3", "ESWOFU3", JdeDataType.String, 100),
        new JdeField("ESWOFU4", "ESWOFU4", JdeDataType.String, 100),
        new JdeField("ESWOFU5", "ESWOFU5", JdeDataType.String, 200),
        new JdeField("ESWOFU6", "ESWOFU6", JdeDataType.String, 200),
        new JdeField("ESWOFU7", "ESWOFU7", JdeDataType.Numeric),
        new JdeField("ESWOFU8", "ESWOFU8", JdeDataType.Numeric),
        new JdeField("ESWOFU9", "ESWOFU9", JdeDataType.Date),
        new JdeField("ESWOFU10", "ESWOFU10", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F952445_0", "Primary Key on ESWOBNM, ESWOUSER", new[] { "ESWOBNM", "ESWOUSER" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F952445_2", "Unique Index on ESWOOBNMS, ESWOBNM, ESWOUSER", new[] { "ESWOOBNMS", "ESWOBNM", "ESWOUSER" }, isUnique: true)
    };
}
