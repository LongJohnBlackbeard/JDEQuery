using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B316 - .
/// </summary>
public class F31B316 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LEWLOTN.
        /// </summary>
        public const string LEWLOTN = "LEWLOTN";

        /// <summary>
        /// LEMCU.
        /// </summary>
        public const string LEMCU = "LEMCU";

        /// <summary>
        /// LEEURID.
        /// </summary>
        public const string LEEURID = "LEEURID";

        /// <summary>
        /// LEBFLG.
        /// </summary>
        public const string LEBFLG = "LEBFLG";

        /// <summary>
        /// LEPERCT.
        /// </summary>
        public const string LEPERCT = "LEPERCT";

        /// <summary>
        /// LELTQNTY.
        /// </summary>
        public const string LELTQNTY = "LELTQNTY";

        /// <summary>
        /// LEUSER.
        /// </summary>
        public const string LEUSER = "LEUSER";

        /// <summary>
        /// LEPID.
        /// </summary>
        public const string LEPID = "LEPID";

        /// <summary>
        /// LEJOBN.
        /// </summary>
        public const string LEJOBN = "LEJOBN";

        /// <summary>
        /// LEUPMJ.
        /// </summary>
        public const string LEUPMJ = "LEUPMJ";

        /// <summary>
        /// LEUPMT.
        /// </summary>
        public const string LEUPMT = "LEUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F31B316";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LEWLOTN", "LEWLOTN", JdeDataType.String, 60, true, true),
        new JdeField("LEMCU", "LEMCU", JdeDataType.String, 24, true, true),
        new JdeField("LEEURID", "LEEURID", JdeDataType.Numeric, null, true, true),
        new JdeField("LEBFLG", "LEBFLG", JdeDataType.String, 2, true, true),
        new JdeField("LEPERCT", "LEPERCT", JdeDataType.Numeric),
        new JdeField("LELTQNTY", "LELTQNTY", JdeDataType.Numeric),
        new JdeField("LEUSER", "LEUSER", JdeDataType.String, 20),
        new JdeField("LEPID", "LEPID", JdeDataType.String, 20),
        new JdeField("LEJOBN", "LEJOBN", JdeDataType.String, 20),
        new JdeField("LEUPMJ", "LEUPMJ", JdeDataType.Numeric),
        new JdeField("LEUPMT", "LEUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B316_0", "Primary Key on LEWLOTN, LEMCU, LEEURID, LEBFLG", new[] { "LEWLOTN", "LEMCU", "LEEURID", "LEBFLG" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B316_2", "Index on LEWLOTN, LEMCU", new[] { "LEWLOTN", "LEMCU" }),
        new JdeIndex("F31B316_3", "Index on LEWLOTN, LEMCU, LEBFLG", new[] { "LEWLOTN", "LEMCU", "LEBFLG" }),
        new JdeIndex("F31B316_4", "Index on LEEURID", new[] { "LEEURID" })
    };
}
