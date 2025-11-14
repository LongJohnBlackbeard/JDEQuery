using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA65A - .
/// </summary>
public class F90CA65A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EXCALLP.
        /// </summary>
        public const string EXCALLP = "EXCALLP";

        /// <summary>
        /// EXCPATTD.
        /// </summary>
        public const string EXCPATTD = "EXCPATTD";

        /// <summary>
        /// EXABLTY.
        /// </summary>
        public const string EXABLTY = "EXABLTY";

        /// <summary>
        /// EXEXVAR0.
        /// </summary>
        public const string EXEXVAR0 = "EXEXVAR0";

        /// <summary>
        /// EXEXVAR1.
        /// </summary>
        public const string EXEXVAR1 = "EXEXVAR1";

        /// <summary>
        /// EXEXVAR2.
        /// </summary>
        public const string EXEXVAR2 = "EXEXVAR2";

        /// <summary>
        /// EXEXVAR3.
        /// </summary>
        public const string EXEXVAR3 = "EXEXVAR3";

        /// <summary>
        /// EXEXVAR4.
        /// </summary>
        public const string EXEXVAR4 = "EXEXVAR4";

        /// <summary>
        /// EXEXVAR5.
        /// </summary>
        public const string EXEXVAR5 = "EXEXVAR5";

        /// <summary>
        /// EXEXVAR6.
        /// </summary>
        public const string EXEXVAR6 = "EXEXVAR6";

        /// <summary>
        /// EXEXVAR7.
        /// </summary>
        public const string EXEXVAR7 = "EXEXVAR7";

        /// <summary>
        /// EXEXNM0.
        /// </summary>
        public const string EXEXNM0 = "EXEXNM0";

        /// <summary>
        /// EXEXNM1.
        /// </summary>
        public const string EXEXNM1 = "EXEXNM1";

        /// <summary>
        /// EXEXNM2.
        /// </summary>
        public const string EXEXNM2 = "EXEXNM2";

        /// <summary>
        /// EXEXNMP0.
        /// </summary>
        public const string EXEXNMP0 = "EXEXNMP0";

        /// <summary>
        /// EXEXNMP1.
        /// </summary>
        public const string EXEXNMP1 = "EXEXNMP1";

        /// <summary>
        /// EXEXNMP2.
        /// </summary>
        public const string EXEXNMP2 = "EXEXNMP2";

        /// <summary>
        /// EXEXDT0.
        /// </summary>
        public const string EXEXDT0 = "EXEXDT0";

        /// <summary>
        /// EXEXDT1.
        /// </summary>
        public const string EXEXDT1 = "EXEXDT1";

        /// <summary>
        /// EXEXDT2.
        /// </summary>
        public const string EXEXDT2 = "EXEXDT2";

        /// <summary>
        /// EXPID.
        /// </summary>
        public const string EXPID = "EXPID";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA65A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EXCALLP", "EXCALLP", JdeDataType.Numeric, null, true, true),
        new JdeField("EXCPATTD", "EXCPATTD", JdeDataType.String, 2000),
        new JdeField("EXABLTY", "EXABLTY", JdeDataType.String, 3002),
        new JdeField("EXEXVAR0", "EXEXVAR0", JdeDataType.String, 510),
        new JdeField("EXEXVAR1", "EXEXVAR1", JdeDataType.String, 510),
        new JdeField("EXEXVAR2", "EXEXVAR2", JdeDataType.String, 510),
        new JdeField("EXEXVAR3", "EXEXVAR3", JdeDataType.String, 510),
        new JdeField("EXEXVAR4", "EXEXVAR4", JdeDataType.String, 100),
        new JdeField("EXEXVAR5", "EXEXVAR5", JdeDataType.String, 100),
        new JdeField("EXEXVAR6", "EXEXVAR6", JdeDataType.String, 100),
        new JdeField("EXEXVAR7", "EXEXVAR7", JdeDataType.String, 100),
        new JdeField("EXEXNM0", "EXEXNM0", JdeDataType.Numeric),
        new JdeField("EXEXNM1", "EXEXNM1", JdeDataType.Numeric),
        new JdeField("EXEXNM2", "EXEXNM2", JdeDataType.Numeric),
        new JdeField("EXEXNMP0", "EXEXNMP0", JdeDataType.Numeric),
        new JdeField("EXEXNMP1", "EXEXNMP1", JdeDataType.Numeric),
        new JdeField("EXEXNMP2", "EXEXNMP2", JdeDataType.Numeric),
        new JdeField("EXEXDT0", "EXEXDT0", JdeDataType.Date),
        new JdeField("EXEXDT1", "EXEXDT1", JdeDataType.Date),
        new JdeField("EXEXDT2", "EXEXDT2", JdeDataType.Date),
        new JdeField("EXPID", "EXPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA65A_0", "Primary Key on EXCALLP", new[] { "EXCALLP" }, isUnique: true, isPrimaryKey: true)
    };
}
